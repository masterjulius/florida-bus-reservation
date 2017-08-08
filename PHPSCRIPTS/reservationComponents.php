<?php
	
	// if ( isset( $_POST['action'] ) ) {

		$id = $_GET['id'];
		$response = array();
		$response["success"] = false;

		$mysqli = new mysqli("localhost", "root", "p@ssw0rd", "db_florida_bus", 3306);
		if ($mysqli->connect_errno) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
		}

		$stmt = "select `tbl_schedules`.`sched_id`, `tbl_schedules`.`sched_date`, `tbl_schedules`.`sched_departure_time`, `tbl_bus`.`bus_id`, `tbl_bus`.`bus_number`, `tbl_bus_class`.`class_id`, `tbl_bus_class`.`class_name`, `tbl_bus_class`.`class_seat_count`, `tbl_bus_class`.`class_seat_price`, `tbl_bus_class`.`class_has_aircon` from `tbl_schedules` left join `tbl_bus` on `tbl_schedules`.`sched_bus_id`=`tbl_bus`.`bus_id` left join `tbl_bus_class` on `tbl_bus`.`bus_class_id`=`tbl_bus_class`.`class_id` where TIMESTAMP(`tbl_schedules`.`sched_date`, `tbl_schedules`.`sched_departure_time`)>=CURRENT_TIMESTAMP() and `tbl_bus`.`bus_is_active`=1 and `tbl_schedules`.`sched_is_active`=1 order by DATE(TIMESTAMP(`tbl_schedules`.`sched_date`, `tbl_schedules`.`sched_departure_time`)) ASC";
		$sql = $mysqli->query($stmt);
		if ( $sql ) {

			$response["num_rows"] = 1;
			$response["success"] = true;
			while ( $obj = $sql->fetch_object() ) {
				$returnArray[] = $obj;
			}

		} else {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Query failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		/* explicit close recommended */
		$sql->close();

		header('Content-Type:Application/json');
		echo json_encode($returnArray); 

	// }

?>