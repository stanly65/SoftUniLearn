<?php

function articles_all()
{
    $art1 = ["id" => 1, "title" => "Title1", "date" => "01.11.2016", "content" => "Content1"];
    $art2 = ["id" => 2, "title" => "Title2", "date" => "01.11.2016", "content" => "Content2"];

    $arr[0] = $art1;
    $arr[1] = $art2;
    return $arr;
}

function articles_get($id)
{
return ["id" => 1, "title" => "Тук ще има заглавие", "date" => "01.11.2016", "content" => "Тук ще има статия"];
}

function articles_new($stile, $date, $content)
{

}

function articles_edit($id, $stile, $date, $content)
{

}

function articles_delete($id)
{

}


?>