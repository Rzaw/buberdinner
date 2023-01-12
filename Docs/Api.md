# Bubber Dinner API

- [Buber Dinner API](#bubber-dinner-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth
### Register
``` js
POST {{host}}/auth/register
```

#### Register Request
``` json
{
    "firstName": "Matijs",
    "lastName": "Lode",
    "email": "admin@root.io",
    "password": "root"
}
```
#### Register Response
``` js
200 OK
```
``` json
{
    "id": "00000000-0000-000-0000-000000000000",
    "firstName": "Matijs",
    "lastName": "Lode",
    "email": "admin@root.io",
    "token": "werwe..twerty"
}
```
### Login
``` js
POST {{host}}/auth/login
```
#### Login Request
``` json
{
    "email": "admin@root.io",
    "password": "root"
}
```
#### Login Response
``` js
200 OK
```
``` json
{
    "id": "00000000-0000-000-0000-000000000000",
    "firstName": "Matijs",
    "lastName": "Lode",
    "email": "admin@root.io",
    "token": "werwe..twerty"
}
```