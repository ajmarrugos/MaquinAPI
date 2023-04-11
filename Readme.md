## MaquinAPI 

A small CRUD REST API project demo, engineered in C# with .NET.

### API REQUEST METHODS

| Api Functions     | Request Method        | Succesful Response                | Unsuccesful Response      | Details                             |
| :---------------: | :-------------------: | :-------------------------------: | :-----------------------: | :---------------------------------: |
| Create            | `POST /Book/{(id)}`   | `201 Created`                     |                           |                                     |
| Read              | `GET /Book/{(id)}`    | `200 Ok`                          |                           | `Location: {(host9}/Books/{(id)})}` |
| Update            | `PUT /Book/{(id)}`    | `204 No Content` or `201 Created` |                           | `Location: {(host9}/Books/{(id)})}` |
| Delete            | `DELETE /Book/{(id)}` | `204 No Content`                  |                           |                                     |
