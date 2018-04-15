FROM alpine
RUN apk update && \
    apk upgrade && \
    apk add bash && \ 
    apk add git

VOLUME [ "/data" ]
WORKDIR /source
ADD ./clone_or_fetch.sh /app/clone_or_fetch.sh

ENV source_repository=https://github.com/dolittle/DotNET.SDK.git

CMD sh /app/clone_or_fetch.sh
