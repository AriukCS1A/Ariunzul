<?php
$host = "localhost";
$user = "root";
$password = "";
$dbname = "cs2a";

$con = mysqli_connect ($host, $user, $password, $dbname);

if (!$con){
    die ("Connection failed!".mysqli_connect_error());
}

echo "Connected!";

if (isset($_POST['reg_submit'])){
    $username = $_POST ['uname'];
    $password = $_POST ['pass'];
    $sql = "INSERT INTO users (name, password) 
                VALUES('$username', '$password')";
    
    if (mysqli_query($con, $sql)){
        echo "New user successfully added";
    }else{
        echo "Error: ".$sql."".mysqli_error ($con);
    }

}
if (isset($_POST ['but_submit'])){
    $uname = mysqli_real_escape_string ($con, $_POST ['txt_name']);
    $password = mysqli_real_escape_string ($con, $_POST ['txt_pass']);
    if ($uname != "" && $password != ""){
        $sql_query = "SELECT count(*) AS u_id FROM users WHERE name = '".$uname."' AND password ='".$password."'";
        $result = mysqli_query ($con, $sql_query);
        $row = mysqli_fetch_array ($result);
        $count = $row ['u_id'];
        if ($count > 0){
            header ('Location: main.php');
        }else {
            echo "Invalid username and password";
        }
    }
}
?>