# Лабораторная работа №6

**Предметная область:** Доставка еды (Dish).
**Технологии:** ASP.NET Core Minimal API, Docker.

## Таблица API

| Метод  | URL                | Назначение      |
|--------|--------------------|-----------------|
| GET    | /api/dishes        | получить список |
| GET    | /api/dishes/{id}   | получить объект |
| POST   | /api/dishes        | создать объект  |
| PUT    | /api/dishes/{id}   | изменить объект |
| DELETE | /api/dishes/{id}   | удалить объект  |

## Примеры JSON-запросов и ответов

**Запрос (POST /api/dishes):**
```json
{
  "name": "Роллы Филадельфия",
  "category": "Суши",
  "price": 600,
  "isAvailable": true
}
Ответ (201 Created):

json
{
  "id": 6,
  "name": "Роллы Филадельфия",
  "category": "Суши",
  "price": 600,
  "isAvailable": true
}
HTTP-статусы
200 OK — успешное получение (GET) или обновление (PUT)

201 Created — успешное создание (POST)

204 No Content — успешное удаление (DELETE)

400 Bad Request — некорректные данные

404 Not Found — объект не найден

Документация
Swagger UI (локально): http://localhost:10000/swagger

Ссылки
GitHub: https://github.com/ihenimo/wt-lab6-6minimalapi-savostikova

Render: https://wt-lab6-6minimalapi-savostikova-1.onrender.com