<?php

	// if ( isset( $_POST['username'], $_POST['password'] ) ) {

		$response = array();
		$response["success"] = false;
		$mysqli = new mysqli("localhost", "root", "p@ssw0rd", "db_florida_bus", 3306);
		if ($mysqli->connect_errno) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
		}

		$stmt = "SELECT `CLIENT_ID`, `CLIENT_USERNAME`, `CLIENT_FIRST_NAME`, `CLIENT_MIDDLE_NAME`, `CLIENT_LAST_NAME` FROM `tbl_clients` WHERE `CLIENT_USERNAME`=? AND `CLIENT_PASSWORD`=? AND `CLIENT_IS_ACTIVE`=1";
		$sql = $mysqli->prepare($stmt);
		if ( !$sql ) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		if ( !$sql->bind_param("ss", $_POST['username'], $_POST['password']) ) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
		    echo "Binding parameters failed: (" . $stmt->errno . ") " . $stmt->error;
		}

		if ( !$sql->execute() ) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "SQL Execution failed: (" . $stmt->errno . ") " . $stmt->error;
		}

		$res = $sql->get_result();
		if ( !$res ) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to get results: (" . $stmt->errno . ") " . $stmt->error;
		}

		if ( $res->num_rows > 0 ) {
			$response["num_rows"] = 1;

			if ( $obj = $res->fetch_object() ) {
				$response["success"] = true;
				$response["user_id"] = $obj->CLIENT_ID;
				$response["username"] = $obj->CLIENT_USERNAME;
			}

		} else {
			$response["num_rows"] = 0;
		}

		/* explicit close recommended */
		$sql->close();

		echo json_encode($response);
		
	// } else {

	// 	exit("No post data passed!");

	// }
	
?>