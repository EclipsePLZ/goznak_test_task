# Тестовое задание для компании Гознак

Окно по работе с программой выглядит следующим образом:
![Окно_программы](https://github.com/EclipsePLZ/goznak_test_task/assets/84061271/7fccb9d0-67fd-407d-9e17-5e6fad2a7473)


По нажатию на кнопку "Выгрузить данные" происходит выгрузка данных из 4-ех датагридов в отдельные xls файлы.

Выгрузка осуществляется с помощью библиотеки EPPlus. Для открытия файлов я пробовал использовать Interop, но он некорректно работает с некоторыми версиями Excel, поэтому я открываю их просто через консоль.
