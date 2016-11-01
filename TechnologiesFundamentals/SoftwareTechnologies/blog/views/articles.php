<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Моят Първи Блог</title>
    <!-- Latest compiled and minified CSS -->

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet"
          href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
</head>
<body>
<div class="container">
    <h1>Моят Първи Блог</h1>
    <div>
        <?php foreach ($articles as $a): ?>
        <div class="article">
            <h3>
                <a href="articles.php?id=<?=$a['id']?>"<?=$a['title']?></a>
            </h3>
            <em>Публикуван: <?=$a['date']?></em>
            <p><?=$a['content']?></p>
        </div>
        <?php endforeach ?>
    </div>
    <footer>
        <p>
            Моят Първи Блог<br>
            Copyright &copy; 2016
        </p>
    </footer>
</div>
</body>
</html>