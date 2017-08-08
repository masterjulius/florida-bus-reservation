<?php
	
	if ( isset( $_GET['sched_id'] ) ) {

		$id = $_GET['sched_id'];
		$response = array();
		$response["success"] = false;

		$mysqli = new mysqli("localhost", "root", "p@ssw0rd", "db_florida_bus", 3306);
		if ($mysqli->connect_errno) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
		}

		$stmt = "select GROUP_CONCAT(distinct `res_seat_numbers` separator ':') as `seats` from tbl_reservations where res_is_active=1 and `res_sched_id`=? group by `res_sched_id`";
		$sql = $mysqli->prepare($stmt);
		if ( !$sql ) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		if ( !$sql->bind_param("i", $id) ) {
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
			$returnArray = array();
			if ( $obj = $res->fetch_object() ) {
				$response["success"] = true;
				$strSplit = explode(":", $obj->seats);
				for ($i=0; $i < count($strSplit); $i++) { 
					$arr = array(
						'seat'	=>	$strSplit[$i]
					);
					array_push($returnArray, $arr);
				}
			}

		} else {
			$response["num_rows"] = 0;
		}

		/* explicit close recommended */
		$sql->close();

		header('Content-Type:Application/json');
		echo json_encode($returnArray); 

	}

?>