<?php
	if ( isset( $_GET['reservation_id'] ) ) {

		$id = $_GET['reservation_id'];
		$response = array();
		$response["success"] = false;

		$mysqli = new mysqli("localhost", "root", "p@ssw0rd", "db_florida_bus", 3306);
		if ($mysqli->connect_errno) {
			$response["error"] = $mysqli->connect_errno . "<br/>" . $mysqli->connect_error;
			echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
		}

		$stmt = "UPDATE `TBL_RESERVATIONS` SET `RES_IS_CANCELLED`=1 WHERE `RES_ID`=? AND `RES_IS_ACTIVE`=1";

		$sql = $mysqli->prepare($stmt);
		if ( !$sql ) {
			$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
			echo "Prepare failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		if ( !$sql->bind_param("i", $id) ) {
			$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
		    echo "Binding parameters failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}

		if ( !$sql->execute() ) {
			$response["error"] = $mysqli->errno . "<br/>" . $mysqli->error;
		    echo "Binding parameters failed: (" . $mysqli->errno . ") " . $mysqli->error;
		}
		if ( $sql->affected_rows > 0 ) {
			$response["success"] = true;
		}

		/* explicit close recommended */
		$sql->close();

		header('Content-Type:Application/json');
		echo json_encode($response);

	}
?>