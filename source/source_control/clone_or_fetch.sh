if [ -d /data/.git ]; 
then
    cp -r /data/. /source
    git fetch --all
else
    git clone $source_repository /source
    cp -r /source/. /data
fi