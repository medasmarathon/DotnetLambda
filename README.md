# Sample AWS Lambda Functions

## Startup Guide

- Install `SAM CLI`: https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/install-sam-cli.html

- `cd ./DotnetLambda`

- `dotnet build`

- `sam build --template-file serverless.template`

- If you wish to test the endpoints locally, run `sam local start-api`

- For deployment, run `sam deploy --guided`

## Endpoints

- GET `/randomproduct/{id}`


- POST `/randomproduct`
    ```json
    {
        "id": 1,
        "summary": "some product summary"
    }
    ```