<?php

	// if ( isset( $_POST['first_name'], $_POST['middle_name'], $_POST['last_name']  ) ) {

		$response = array();
		$response["success"] = false;
		$response["message"] = "default";
		$response["duplicated"] = false;

		/** get details */
		$first_name = $_POST['firstName'];
		$middle_name = $_POST['middleName'];
		$last_name = $_POST['lastName'];
		$username = $_POST["username"];
		$password = $_POST["password"];
		$address = $_POST['address'];
		$birthPlace = $_POST['birthPlace'];
		$contact = $_POST['contact'];

		$mysqli = new mysqli("localhost", "root", "p@ssw0rd", "db_florida_bus", 3306);
		if ($mysqli->connect_errno) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
		}

		// select first if existing
		$sel = $mysqli->prepare("SELECT `CLIENT_ID` FROM `TBL_CLIENTS` WHERE `CLIENT_FIRST_NAME`=? AND `CLIENT_MIDDLE_NAME`=? AND `CLIENT_LAST_NAME`=? AND `CLIENT_CONTACT`=? AND `CLIENT_ADDRESS`=? AND `CLIENT_BIRTH_PLACE`=? AND `CLIENT_IS_ACTIVE`=1");
		if ( !$sel ) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		if ( !$sel->bind_param("ssssss", $first_name, $middle_name, $last_name, $contact, $address, $birthPlace) ) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
		    echo "Binding parameters failed: (" . $stmt->errno . ") " . $stmt->error;
		}

		if ( !$sel->execute() ) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		$res = $sel->get_result();
		if ( $res->num_rows > 0 ) {

			$response["duplicated"] = true;
			$response["message"] = "Account Already Exists!";

		} else {

			// --------------------------------------------------------------------------

			$stmt = "INSERT INTO `TBL_CLIENTS` (`CLIENT_FIRST_NAME`, `CLIENT_MIDDLE_NAME`, `CLIENT_LAST_NAME`, `CLIENT_USERNAME`, `CLIENT_PASSWORD`, `CLIENT_CONTACT`, `CLIENT_ADDRESS`, `CLIENT_BIRTH_PLACE`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
			$sql = $mysqli->prepare($stmt);
			if ( !$sql ) {
				$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
				echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
			}

			if ( !$sql->bind_param("ssssssss", $first_name, $middle_name, $last_name, $username, $password, $contact, $address, $birthPlace) ) {
				$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			    echo "Binding parameters failed: (" . $stmt->errno . ") " . $stmt->error;
			}

			if ( $sql->execute() ) {
				$response["success"] = true;
			} else {
				$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			}

			/* explicit close recommended */
			$sql->close();

		}

		echo json_encode($response); 
		
	// } else {

	// 	exit("No post data passed!");

	// }
	
?>