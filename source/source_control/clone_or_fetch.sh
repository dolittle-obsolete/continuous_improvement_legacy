if [ -d /data/.git ]; 
then
    cp -r /data/. /source
    git fetch --all
else
    git clone --recursive $source_repository /source
    cp -r /source/. /data
fi