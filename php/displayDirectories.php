<?php
function showContent($path) {

  if ( $handle = opendir($path) ) {

    $files = array();
    $folders = array();

    while ( false !== ($file = readdir($handle)) ) {

      if ( ($file[0] != ".") && ($file != "index.php") ) {

        $fName  = $file;
        $file   = $path.'/'.$file;
               
        if( is_file($file) ) {
          $files[] = $file;
        } elseif ( is_dir($file) ) {
          $folders[] = $file;
        }
      }
    }

    closedir($handle);
 }

  $up = substr($path, 0, (strrpos(dirname($path."/."),"/")) );
  if ($path != ".") {
    echo "<h2><a href='".$_SERVER['PHP_SELF']."?path=$up'>Up One Level</a></h2>";
    $pieces = explode($path, "/");
    $num = count($pieces);
    echo "<center><h2>Path: $path</h2></center>";
  } else {
    echo "<h2>Up One Level</h2>";
    echo "<center><h2>Path: root</h2></center>";
  }  

  echo "<h2>Folders</h2>";
  echo "<p>";
  if ( !empty($folders) ) {
    sort($folders);
    foreach ($folders as $folder) {
      $pieces = explode("/", $folder);
      $num = count($pieces) - 1;
      print "<a href='".$_SERVER['PHP_SELF']."?path=$folder'>$pieces[$num]</a><br>";
    }
  }
  else echo "None";
  echo "</p>";

  echo "<h2>Files</h2>";
  echo "<p>";
  if ( !empty($files) ) {
    sort($files);
    foreach ($files as $file) {
      $pieces = explode("/", $file);
      $num = count($pieces) - 1;
      echo "<a href='".$file."'>".$pieces[$num]."</a><br>";
    }
  }
  else echo "None";
  echo "</p>";
}

if (isset($_POST['submitBtn'])){
    $actpath = isset($_POST['path']) ? $_POST['path'] : '.';    
} else {
    $actpath = isset($_GET['path']) ? $_GET['path'] : '.';    
}

?>

<h1>Downloads</h1>

<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" name="path">
  <input class="text" name="path" type="hidden" value="<?php echo $actpath; ?>" />
</form>

<?php
  showContent($actpath);        
?>