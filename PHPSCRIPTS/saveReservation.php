<?php

	// if ( isset( $_POST['first_name'], $_POST['middle_name'], $_POST['last_name']  ) ) {

		$response = array();
		$response["success"] = false;

		// get details
		$res_sched_id = $_POST['res_sched_id'];
		$res_type = 2;
		$res_bus_class_id = $_POST['res_bus_class_id'];
		$res_bus_id = $_POST['res_bus_id'];
		$res_seat_numbers = $_POST['res_seat_numbers'];
		$res_client_id = $_POST['res_client_id'];

		$total_price = $_POST['total_price'];

		$mysqli = new mysqli("localhost", "root", "p@ssw0rd", "db_florida_bus", 3306);
		if ($mysqli->connect_errno) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
		}

		$stmt = "INSERT INTO `tbl_reservations` (`res_sched_id`, `res_type`, `res_code`, `res_bus_class_id`, `res_bus_id`, `res_seat_numbers`, `res_client_id`) values(?, ?, CONCAT( 'GV-', DATE_FORMAT(current_timestamp(), '%y%m%d%h%m%s'), '-', CONCAT( FLOOR(RAND()*(9-0+1))+0, FLOOR(RAND()*(9-0+1))+0, FLOOR(RAND()*(9-0+1))+0) ), ?, ?, ?, ?)";
		$sql = $mysqli->prepare($stmt);
		if ( !$sql ) {
			$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
			echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		if ( !$sql->bind_param("iiiisi", $res_sched_id, $res_type, $res_bus_class_id, $res_bus_id, $res_seat_numbers, $res_client_id) ) {
			$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
		    echo "Binding parameters failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		// $args = array();
		// $args[0] = 0;
		// $args[1] = 1;
		// $args[2] = 5;
		// $args[3] = 13;
		// $args[4] = "1:2:3";
		// $args[5] = 4;

		// if ( !$sql->bind_param("iiiisi", $args[0], $args[1], $args[2], $args[3], $args[4], $args[5]) ) {
		// 	$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
		//     echo "Binding parameters failed: (" . $mysqli->errno . ") " . $mysqli->error;
		// }

		if ( $sql->execute() ) {
			$last_sched_id = $mysqli->insert_id;

			// insert into transactions
			$trans = $mysqli->prepare("INSERT INTO `TBL_TRANSACTIONS` (`TRANS_RESERVATION_ID`, `TRANS_TOTAL_PAYMENT`) VALUES (?, ?)");

			if ( !$trans ) {
				$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
				echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
			}

			if ( !$trans->bind_param("is", $last_sched_id, $total_price) ) {
				$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
			    echo "Binding parameters failed: (" . $mysqli->errno . ") " . $mysqli->error;
			}

			if ( !$trans->execute() ) {
				$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
				echo "SQL Execution failed: (" . $mysqli->errno . ") " . $mysqli->error;
			}

			// -----------------------------------------------------------------------------------------------------

			$select = $mysqli->prepare("select `res_code` from `tbl_reservations` where `res_id`=? and `res_is_active`=1");

			if ( !$select ) {
				$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
				echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
			}

			if ( !$select->bind_param("i", $last_sched_id) ) {
				$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
			    echo "Binding parameters failed: (" . $mysqli->errno . ") " . $mysqli->error;
			}

			if ( !$select->execute() ) {
				$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
				echo "SQL Execution failed: (" . $mysqli->errno . ") " . $mysqli->error;
			}

			$res = $select->get_result();
			if ( !$res ) {
				$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
				echo "Failed to get results: (" . $mysqli->errno . ") " . $mysqli->error;
			}

			if ( $res->num_rows > 0 ) {
				if ( $obj = $res->fetch_object() ) {
					$response["num_rows"] = 1;
					$response["success"] = true;
					$response["reservation_code"] = $obj->res_code;
				}

			} else {
				$response["num_rows"] = 0;
			}

		} else {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
		}

		/* explicit close recommended */
		$sql->close();

		echo json_encode($response); 
		
	// } else {

	// 	exit("No post data passed!");

	// }
	
?>