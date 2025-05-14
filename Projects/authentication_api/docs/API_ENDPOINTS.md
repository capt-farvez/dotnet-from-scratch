`1.    POST /api/auth/register`
- Request Body:

```json
{
    "Name": "John Doe",
    "Email": "john.doe@example.com",
    "Password": "password123"
}
```
---
`2.    POST /api/auth/login`
- Request Body:
``` json
{
    "Email": "john.doe@example.com",
    "Password": "password123"
}
```
---
` 3. POST /api/auth/logout`
- Logout the user
---
`4. GET /api/profile`
- Return user Details
---
`5. PUT /api/profile`
- Request Body
```json
{
    "Name": "John Doe",
    "Email": "john.doe@example.com"
}
```