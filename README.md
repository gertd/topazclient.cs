# topazclient.cs

Simple DotNet Core CSharp gRPC client for Topa


To run:

1) Ensure topaz is installed 
2) Install the `gdrive` template using: `topaz templates install gdrive`
3) If the template was already installed, ensure the current context is set to use the template, using: `topaz config use gdrive`
4) Confirm using: `topaz config list`

```
topaz config list
     NAME       CONFIG FILE
  *  gdrive     gdrive.yaml
```

5) Run the sample, using: `dotnet run`
 
```
dotnet run
type: user id: beth@the-smiths.com
type: user id: jerry@the-smiths.com
type: user id: morty@the-citadel.com
type: user id: rick@the-citadel.com
type: user id: summer@the-smiths.com
```


