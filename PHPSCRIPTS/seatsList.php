<?php
	
	if ( isset( $id = $_GET['id']) ) {

		$id = $_GET['id'];
		$response = array();
		$response["success"] = false;

		$mysqli = new mysqli("localhost", "root", "p@ssw0rd", "db_florida_bus", 3306);
		if ($mysqli->connect_errno) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
		}

		$stmt = "select ";
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

	}

?>