# actionable-restful-api-errors
A sample implementation of actionable RESTful API errors using ASP.NET Web API and FluentValidation

Sample HTTP request to trigger validation:

POST to http://HOST:PORT/api/users/

Headers:

Content-Type: application/json

Body:

```json
{
   "username":"dai",
   "address":{}
}
```
