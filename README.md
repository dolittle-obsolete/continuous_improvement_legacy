# Continuous Improvement

This is the main repository for the Dolittle Continuous Improvement system - build -> deliver -> deploy

## Cloning

This repository has sub modules, clone it with:

```shell
$ git clone --recursive <repository url>
```

If you've already cloned it, you can get the submodules by doing the following:

```shell
$ git submodule update --init --recursive
```

## Testing against GitHub WebHooks

In order to be able to test with real GitHub WebHooks you need to have a public address. Using a reverse proxying tool
will get you there. Download [ngrok](https://ngrok.com/download) for this, recommend putting it in your path or making
an alias for it to where you put it.

Run the application and it should then show:

```shell
Now listening on: http://localhost:5000
```

Once that is done, open a console/terminal and run:

```shell
$ ngrok http 5000
```

You should then get something like this:

```shell
Session Status                online
Session Expires               7 hours, 54 minutes
Version                       2.2.8
Region                        United States (us)
Web Interface                 http://127.0.0.1:4040
Forwarding                    http://1e2e33c1.ngrok.io -> localhost:5000
Forwarding                    https://1e2e33c1.ngrok.io -> localhost:5000
```

The public DNS address can then be used for this.