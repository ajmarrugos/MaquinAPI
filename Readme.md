## MaquinAPI 

A simple **REST API** project demo, engineered in **C#** and assembled with **.NET.**

#### HOW TO TRY IT?

- **Download** the Project
`github clone https://github.com/ajmarrugos/MaquinAPI`

- **Build** the Project
`dotnet build`

- **Run** the project
`dotnet run .\MaquinAPI\`

#### HOW TO USE IT?

You can start by reviewing the structure of the **Request** you want to make, **for example:**
```
POST http://localhost:8080/users
Content-Type: application/json
```

And then review the structure of the **JSON** that the API Model allows you to interact with. Currently you'll be able to work with: **/users**

```
[
  {
    "id": 1,
    "name": "Alberto Marrugo",
    "username": "ajmarrugos",
    "email": "ajmarrugos@gmail.com",
    "address": {
      "street": "Boyaca",
      "suite": "Apt. 007",
      "city": "Bogota",
      "zipcode": "0101010",
      "geo": {
        "lat": "-37.3159",
        "lng": "81.1496"
      }
    },
    "phone": "57-300-416-1450",
    "website": "github.com/ajmarrugos",
    "company": {
      "name": "Unosquare",
      "catchPhrase": "Nearshore Software Engineers For Your Digital Transformation",
      "bs": "Digital Engineering"
    }
  }
]
```

Finally you can retry with **other methods** depending on your intention:
Here's a list of the possible ways to communicate with the API:

| Api Functions     | Request Method          | Successful Response                | Unsuccessful Response      | Details                             |
| :---------------: | :---------------------: | :-------------------------------: | :-----------------------: | :---------------------------------: |
| Create            | `POST /Object/{(id)}`   | `201 Created`                     |                           |                                     |
| Read              | `GET /Object/{(id)}`    | `200 Ok`                          |                           | `Location: {(host}/Object/{(id)})}` |
| Update            | `PUT /Object/{(id)}`    | `204 No Content` or `201 Created` |                           | `Location: {(host}/Object/{(id)})}` |
| Delete            | `DELETE /Object/{(id)}` | `204 No Content`                  |                           |                                     |
