## MaquinAPI 

A small CRUD REST API project demo, engineered in C# with .NET.

### HOW TO TRY IT?

Download the Project
github clone https://github.com/ajmarrugos/MaquinAPI

Build the Project
dotnet build

Run the project
dotnet run .\MaquinAPI\

### API REQUEST METHODS

| Api Functions     | Request Method          | Successful Response                | Unsuccessful Response      | Details                             |
| :---------------: | :---------------------: | :-------------------------------: | :-----------------------: | :---------------------------------: |
| Create            | `POST /Object/{(id)}`   | `201 Created`                     |                           |                                     |
| Read              | `GET /Object/{(id)}`    | `200 Ok`                          |                           | `Location: {(host}/Object/{(id)})}` |
| Update            | `PUT /Object/{(id)}`    | `204 No Content` or `201 Created` |                           | `Location: {(host}/Object/{(id)})}` |
| Delete            | `DELETE /Object/{(id)}` | `204 No Content`                  |                           |                                     |
