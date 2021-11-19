# FISharer

## Описание

У каждого в жизни наступает момент, когда необходимо срочно и безотлагательно поделиться с близкими, друзьями или коллегами важной информацией, однако под рукой не всегда бывают инструменты, которые позволяют сделать это. **FISharer** - это сервис обмена данными, который за считанные секунды загружает и доставляет тысячи байтиков по всему интернету прямоком андесанту. Без смс и регистрации. Только файлы и ссылка на них.

## Технические особенности

Главная особенность сервиса - **никакой базы данных**. Когда речь идет об обмене данными, то постараться сделать обмен ими, не прибегая к использованию баз данных. 

Если проект доживет хотя бы до релиза, то можно воплотить возможность хранения данных на постоянной основе (используя хранилища или облако).

## План реализации сервиса

- [X] Написать план по реализации данного сервиса
- [ ] Сделать наброски дизайна главной страницы сайта
  - [X] Блок-призыва. Предложить обменяться файлами (ведет на страницу обмена файлами)
  - [X] Блок-приветствие. Рассказать о возможностях сервиса
  - [X] Блок с подписками.
  - [X] Сделать анимацию блоков при скролле страницы вниз
  - [X] Сверстать главную страницу под телефоны
  - [ ] Сделать адаптив главной страницы под ПК
- [X] Подготовить страницу загрузки файлов
  - [ ] Сверстать главную страницу под телефоны и сделать адаптив под ПК
- [ ] Подготовить страницу загруженных файлов и файлов в ожидании скачивания
  - [ ] Сверстать главную страницу под телефоны и сделать адаптив под ПК
- [ ] Динамическое обновление страницы. Никаких перезагрузок
- [ ] Бэкенд часть
  - [x] Претотипирование (сразу опускаем, потому что по большому счету смысла нет, ведь все ради практики)
  - [ ] Проектирование. Визуализировать связи внутренних компонентов и сервисов
  - [ ] Перенести спроектированный проект в код
  - [X] Возможность загружать файлы на сервер
  - [ ] ??? Временное хранилище для файлов
  - [X] Скачивание файлов с сервера
  - [ ] Ввести таймер хранения данных обмена (базовый пакет: 20 минут)
  - [ ] Ввести ограничение на объем загружаемых файлов для "обычных" пользователей

## Рекоммендации

* Методология БЭМ
* Подход Modile-first
* Максимально простое взаимодействие с UI (UX)
* Воспользоваться переменными в каскадных таблицах для предотвращения копипаста
* Использовать больше динамики на сайте (анимации, переходы)

## Сроки выполнения и сдачи проекта

С момента начала работы (первого "рабочего" коммита в репозитории) выделяется **30 календарных дней** на обдумывание плана по реализации проекта, верстку прототипа сайта и проектирование бэкенда. По истечению этого срока подготовить отчет о выполненной работе; задокументировать изменения в changelog'е и приступить к выполнению основной работы. 

На завершение основной работы (сайт, бэкенд) с момента сдачи прототипа выделяется **45 календарных дней**. 

Итого, срок выполнения проекта ограничивается **75 днем** с момента первого коммита в данном репозитории.

