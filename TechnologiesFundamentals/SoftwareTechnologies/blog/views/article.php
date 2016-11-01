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

            <div class="article">
                <h3>
                    <?=$article['title']?>
                </h3>
                <em>Публикуван: <?=$article['date']?></em>
                <p><?=$article['content']?></p>
            </div>

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