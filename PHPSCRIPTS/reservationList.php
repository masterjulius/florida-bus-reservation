<?php
	
	if ( isset( $_GET['client_id']) ) {

		$id = $_GET['client_id'];
		$response = array();
		$response["success"] = false;
		$returnArray = array();

		$mysqli = new mysqli("localhost", "root", "p@ssw0rd", "db_florida_bus", 3306);
		if ($mysqli->connect_errno) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
		}

		$stmt = "SELECT `TBL_SCHEDULES`.`SCHED_ID`, `TBL_SCHEDULES`.`SCHED_DATE`, `TBL_SCHEDULES`.`SCHED_DEPARTURE_TIME`, `TBL_RESERVATIONS`.`RES_ID`, `TBL_RESERVATIONS`.`RES_SCHED_ID`, `TBL_RESERVATIONS`.`RES_TYPE`, `TBL_RESERVATIONS`.`RES_CODE`, `TBL_RESERVATIONS`.`RES_BUS_CLASS_ID`, `TBL_RESERVATIONS`.`RES_BUS_ID`, `TBL_RESERVATIONS`.`RES_SEAT_NUMBERS`, `TBL_BUS_CLASS`.`CLASS_SEAT_PRICE`, `TBL_BUS_CLASS`.`CLASS_NAME`, `TBL_BUS`.`BUS_NUMBER`, `TBL_TRANSACTIONS`.`TRANS_ID`, `TBL_TRANSACTIONS`.`TRANS_TOTAL_PAYMENT` FROM `TBL_RESERVATIONS` LEFT JOIN `TBL_SCHEDULES` ON `TBL_RESERVATIONS`.`RES_SCHED_ID`=`TBL_SCHEDULES`.`SCHED_ID` LEFT JOIN `TBL_BUS_CLASS` ON `TBL_RESERVATIONS`.`RES_BUS_CLASS_ID`=`TBL_BUS_CLASS`.`CLASS_ID` LEFT JOIN `TBL_BUS` ON `TBL_BUS`.`BUS_CLASS_ID`=`TBL_BUS_CLASS`.`CLASS_ID` LEFT JOIN `TBL_TRANSACTIONS` ON `TBL_TRANSACTIONS`.`TRANS_RESERVATION_ID`=`TBL_RESERVATIONS`.`RES_ID` WHERE `TBL_RESERVATIONS`.`RES_IS_CANCELLED`=0 AND `TBL_RESERVATIONS`.`RES_IS_ACTIVE`=1 AND `TBL_RESERVATIONS`.`RES_CLIENT_ID`=? AND TIMESTAMP(`tbl_schedules`.`sched_date`, `tbl_schedules`.`sched_departure_time`)>=CURRENT_TIMESTAMP() AND `RES_IS_CANCELLED`=0";
		$sql = $mysqli->prepare($stmt);
		if ( $sql ) {

			if ( !$sql->bind_param("i", $id ) ) {
				$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
				echo "Query failed: (" . $mysqli->errno . ") " . $mysqli->error;
				die();
			}

			if ( $sql->execute() ) {



				$res = $sql->get_result();
				if ( !$res ) {
					$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
					echo "Failed to get results: (" . $stmt->errno . ") " . $stmt->error;
				}

				if ( $res->num_rows > 0 ) {
					$response["num_rows"] = $res->num_rows;
					$response["success"] = true;
					while ( $obj = $res->fetch_object() ) {
						$returnArray[] = $obj;
					}

				} else {
					$response["num_rows"] = 0;
				}	

			}

		} else {
			$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
			echo "Query failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		/* explicit close recommended */
		$sql->close();

		header('Content-Type:Application/json');
		echo json_encode($returnArray);

	}

?>