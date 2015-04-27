ls
vim shippable.yml 
clear
ls -l
mkdir -p tools/Regional; cd tools; curl -o Regional.tar.gz -L https://github.com/Korovasoft/Regional/archive/v1.0.2.tar.gz; tar xzf Regional.tar.gz -C Regional --strip-components=1
mkdir -p build/tex; cd build/tex; python3 ../../tools/Regional/regional.py ../../example-projects/fractals/src/app/fractals/fractals.cpp
mkdir -p build/tex; cd build/tex; python ../../tools/Regional/regional.py ../../example-projects/fractals/src/app/fractals/fractals.cpp
ls
cd ..
mkdir -p build/tex; cd build/tex; python ../../tools/Regional/regional.py ../../example-projects/fractals/src/app/fractals/fractals.cpp
ls
clear
ls -l
cd ..
ls
cd ..
ls
cd t
cd ..
ls
clear
ls -l
cd ..
ls
rm -rf tools/ build/
ls
clear
ls -l
cd images/
ls
cd ..
ls
clear
ls -l
mkdir -p tools/Regional; cd tools; curl -o Regional.tar.gz -L https://github.com/Korovasoft/Regional/archive/v1.0.2.tar.gz; tar xzf Regional.tar.gz -C Regional --strip-components=1
cd ..
ls
mkdir -p build/tex; cd build/tex; python ../../tools/Regional/regional.py ../../example-projects/fractals/src/app/fractals/fractals.cpp
ls
cd ..
cd. .
cd ..
ls
clear
ls -l
cim contents/some_links_to_the_past.tex 
vim contents/some_links_to_the_past.tex 
ls
clear
ls -l
cd build/
ls
cmake ..
make -j2
cd. .
ls
cd ..
ls
rm -rf build/
ls
clear
ls -l
rm -rf tools/
ls
clear
ls -l
git status
git add images/Fractal-fern.png 
git status
git rm images/Fractal_fern.png 
git status
git commit -m 'Renaming fractal fern image'
ls
clear
ls -l
git status
git diff example-projects/fractals/CMakeLists.txt 
ls
git status
git add example-projects/fractals/CMakeLists.txt 
git commit -m 'Changing reference to CMake modules to be based off of project instead of global CMake.'
git status
clear
ls -l
git status
git add contents/fractals.tex 
git commit -m 'Adding test fractal chapter to import generated fractal image.'
git status
clear
ls -l
git status
git diff contents/some_links_to_the_past.tex 
git add contents/some_links_to_the_past.tex 
git commit -m 'Adding back in snippet example'
git status
git diff book_main.tex 
ls
git add book_main.tex 
git commit -m 'Adding in image example for non-generated examples. Also adding in chapter that uses generated images.'
git status
git diff CMakeLists.txt 
vim CMakeLists.txt 
git status
git add CMakeLists.txt 
git commit -m 'Adding correct depends on all fractals targets. Adding in images location for UseLATEX. Correcting build artifacts step to correctly copy items.'
git pull
git status
git merge origin master
git push
git status
clear
ls -l
git status
clear
ls -l
git status
exit
ls
cd Downloads/repos/
ls
cd sse-book/
git pull
git status
ls
clear
ls -l
git fetch --prune
git pull
clear
ls -l
git status
clear
ls -l
cd CMakeLists.txt 
ls
cd ..
ls
cd sse-book/
ls
cd CMakeLists.txt 
ls
cd ..
ls
cd -
ls
vim CMakeLists.txt 
ls
clear
ls -l
cd example-projects/
ls
cd fractals/
ls
vim CMakeLists.txt 
ls
cler
als -l
clear
ls -l
git branch
git branch -ra
git branch -d feature_top-level-cmake
git branch
git branch -rav
git checkout feat_create-ext-lodepng
git pull
git merge master
git pull
ls
clear
git status
git push
clear
ls -l
clear
ls- l
git status
clear
ls -l
rm -rf build
ls
cd ..
ls
clear
ls -l
vim shippable.yml 
git checkout master
ls
clear
ls -l
git checkout -b clean-up-shippable
git status
ls
vim shippable.yml 
ls
clear
ls -l
vim CMakeLists.txt 
git status
git diff shippable.yml 
ls
git checkout master
git status
git checkout clean-up-shippable
git add -A
git status
git commit -m 'Moving installs to YML install target.'
git pus
git push
git push --set-upstream origin clean-up-shippable
ls
git checkout master
git branhc
git branch
git status
clear
git checkout -b origin/feat_enhance-cmake-to-run-apps
git checkout master
git branch -d origin/feat_enhance-cmake-to-run-apps
ls
git status
git branch -rv
git fetch --prune
git branch -rv
git checkout -b feat_enhance-cmake-to-run-apps
git status
git push
git push --set-upstream origin feat_enhance-cmake-to-run-apps
git status
git pull
ls
mkdir build
cd build/
cmake ..
make
ls
cd. .
cd ..
ls
cleaer
ls -l
clear
ls -l
cd build/
ls
cd fractals-build/
ls
cd build
cd build-files/
ls
cd src/
ls
cd app/
ls
./fractals 
ls
cleaer
clear
ls -l
cd ..
cd. .
cd ..
ls
clear
ls -l
vim CMakeLists.txt 
rm -rf build/
mkdir build
rm -rf build/
(mkdir build; cd build; cmake ..; make;)
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
clear
ls -l
vim example-projects/fractals/src/app/fractals/fractals.cpp 
ls
git status
ls
cd contents/
ls
cd ..
ls
vim book_main.tex 
ls
clear
ls -l
cd contents/
ls
vim some_links_to_the_past.tex 
ls
clear
ls -l
cd ..
ls
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
clear
ls -l
git status
git diff CMakeLists.txt 
ls
clear
ls -l
git status
git diff book_main.tex 
ls
clear
ls -l
git diff
git status
clear
ls -l
git status
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
ls build/fractals-build/build-files/src/app/
ls
cd build/
ls
cd fractal
ls
l
ls
cd ..
ls
clear
ls -l
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
lcd build/
ls build/
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
cd build/
ls
cd ..
ls
cd build/
ls
cd ..
ls
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
rm rf shippable
cd shippable
ls
cd ..
ls
rm -rf shippable
ls
cd build/
ls
cd build-artifacts/
ls
cd ..
ls
clear
ls -l
vim shippable.yml 
git status
git add example-projects/*
git status
git commit -m 'Removing printing of fractal image since it serves no purpose at all.'
git status
git add book_main.tex 
git commit -m 'Adding some whitespace and some comment markers for sections.'
git status
git diff contents/some_links_to_the_past.tex 
ls
clear
ls -l
git status
git add contents/some_links_to_the_past.tex 
git commit -m 'Updating link to new snippet section since I removed the image printing. Now the snippet should just be the creation of a fractl.'
git status
git diff CMakeLists.txt 
ls
clear
ls -l
git status
git add CMakeLists.txt 
git status
git commit
git status
git diff shippable.yml 
git add shippable.yml 
clear
ls- l
git commit -m 'Changing shippable to pull all contenst from build-artifacts now. This decouples the need for shippable in the future is need be. Just by running the build you will get a local artifacts directory. We can then bolt on any third-party item to do with how they choose (like we do with shippable).'
git status
clear
ls- l
clear
sl -l
git status
git push
clear
ls -l
ls
clear
ls -l
git status
ls
clear
ls -l
cd contents/
ls
clear
ls -l
cp gnu_autotools.tex fractals.tex
ls
vim fractals.tex 
ls
cd ..
ls
vim book_main.tex 
mkdir images
ls
clear
ls -l
ls
vim CMakeLists.txt 
ls
rm -rf ~
ls
git status
rm \~
ls
clear
ls -l
cd ~
ls
cd Downloads/
ls
cd repos/
ls
cd sse-book/
ls
clear
ls -l
clear
ls -l
git status
vim book_main.tex 
lsls
ls
clear
ls -l
ls
clear
ls -l
git status
vim contents/fractals.tex 
ls
clear
ls -l
cd build/
ls
cd ..
ls
clear
ls -l
vim CMakeLists.txt 
ls
clear
ls -l
git status
clear
ls l
clear
ls -l
vim shippable.yml 
ls
git pull
git status
git pull
clear
ls -l
git merge master
git status
git pull
clear
ls -l
vim book_main.tex 
ls
clear
ls -l
git status
clear
ls -l
vim CMakeLists.txt 
ls
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
cd images/
ls
clear
ls -l
cd ..
ls
clear
ls -l
vim CMakeLists.txt 
cd
ls
git clone https://github.com/calebwherry/Code.git
cd Code/
ls
cd dot_files/
ls
ls .* ~/
cp .* ~/
ls
cd ..
source .bashrc
ls
clear
ls -l
ls -la
rm -rf Code/
ls
clear
ls -l
cd Downloads/
ls
cd repos/
ls
cd sse-book/
ls
clear
ls -l
vim CMakeLists.txt 
ls
clear
ls -l
git status
clear
ls -l
git status
git diff CMakeLists.txt 
ls
clear
ls -l
rm -rf build/
ls
clear
ls -l
cd images/
sl
ls
clear
ls -l
git status
cd ..
ls
clear
ls -l
ls
clear
ls -l
cd images/
ls
rm fractal.png 
ls
clear
ls -l
cd ..
ls
clear
ls -l
vim book_main.tex 
vim contents/fractals.tex 
ls
clear
ls -l
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
git status
git diff book_main.tex 
vim book_main.tex 
ls
git diff book_main.tex 
ls
clear
ls -l
vim book_main.tex 
git status
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
git status
cd images/
ls
rm -rf fractal.png 
ls
cd ..
ls
clear
ls -l
git add images/
ls
git status
git commit -m 'Adding creative commons image for front of book image testing.'
clear
ls -l
git status
git contents/fractals.tex 
git diff contents/fractals.tex 
git add contents/fractals.tex 
git status
git reset HEAD contents/fractals.tex 
ls
git status
git diff book_main.tex 
ls
vim book_main.tex 
ls
git status
git add book_main.tex 
git commit -m 'Adding new title pic and image for front cover.'
git status
git diff CMakeLists.txt 
git add CMakeLists.txt 
git commit -m 'Fixing issues with location of files to copy and create.'
git status
git push
git pull
git merge master
clear
ls -l
git status
git pull origin master
git status
ls
clear
git push
git status
clear
ls -l
ls
vim shippable.yml 
git status
clear
ls -l
git push
clear
ls -l
ls
clear
ls -l
vim shippable.yml 
mkdir -p tools/Regional; cd tools; curl -o Regional.tar.gz -L https://github.com/robertdfrench/Regional/archive/v1.0.2.tar.gz; tar xzf Regional.tar.gz -C Regional --strip-components=1
cd tools; curl -o Regional.tar.gz -L https://github.com/robertdfrench/Regional/archive/v1.0.2.tar.gz
ls
curl -o Regional.tar.gz -L https://github.com/robertdfrench/Regional/archive/v1.0.2.tar.gz
sudo apt-get install curl
ls
cd ..
ls
rm -rf tools/
mkdir -p tools/Regional; cd tools; curl -o Regional.tar.gz -L https://github.com/robertdfrench/Regional/archive/v1.0.2.tar.gz; tar xzf Regional.tar.gz -C Regional --strip-components=1;
ls
ls -la
curl -o Regional.tar.gz -L https://github.com/robertdfrench/Regional/archive/v1.0.2.tar.gz
ls -la
cd. 
cd. .
cd ..
rm -rf tools/
ls
vim shippable.yml 
ls
clear
ls -l
vim contents/some_links_to_the_past.tex 
ls
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
vim book_main.tex 
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim book_main.tex 
ls
clear
ls -l
rm -rf build/
ls
clear
ls -l
cd images/
ls
cd ..
vim CMakeLists.txt 
ls
clear
ls -l
cd images/
ls
cd ..
ls
clear
ls -l
clear
ls -l
vim shippable.yml 
ls
clear
ls -l
vim book_main.tex 
ls
clear
ls- l
vim book_main.tex 
vim CMakeLists.txt 
git status
git diff shippable.yml 
git add shippable.yml 
git commit -m 'Change location of Regional repo'
git status
git diff CMakeLists.txt 
git add CMakeLists.txt 
git commit -m 'Adding images dif to UseLATEX'
git statys
git status
git diff book_main.tex 
git add book_main.tex 
git commit -m 'Adding back in titlepic'
git status
git diff contents/some_links_to_the_past.tex 
ls
git add contents/some_links_to_the_past.tex 
git commit -m 'Removing snippet example for now'
git status
git pull
git push
git status
git pull
clear
ls -l
ls
clear
ls -l
git status
vim shippable.yml 
git add CMakeLists.txt 
git commit -m "Adding -p to shippable since RObert decided to go ahead and make the build directory. I'm not so sure he tested that stuff enough..."
git add shippable.yml 
git commit -m "Adding -p to shippable since RObert decided to go ahead and make the build directory. I'm not so sure he tested that stuff enough..."
(rm -rf build; mkdir build; cd build; cmake ..; make;)
pdftops
sudo apt-get install pdftops
sudo apt-get install poppler-utils
(rm -rf build; mkdir build; cd build; cmake ..; make;)
sudo apt-get install imagemagick
(rm -rf build; mkdir build; cd build; cmake ..; make;)
git status
git diff shippable.yml 
git add shippable.yml 
git commit -m 'Adding a few more depends since I am now including images into the latex source.'
git status
git push
git pull
git merge origin master
git pull
git status
git push
clear
ls -l
git status
vim shippable.yml 
ls
git add shippable.yml 
git commit -m 'Adding in saying yes to installs'
git push
git pull
clear
ls -l
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
cd build/
ls
cd build-artifacts/
s
ls
open fractal.png 
cd. .
cd ..
git status
git diff CMakeLists.txt 
it add CMakeLists.txt 
git add CMakeLists.txt 
git commit -m 'Correcting wrong path to built book PDF'
git push
git pull
git status
clear
ls -l
git status
clear
ls- l
clear
ls -l
vim book_main.tex 
vim CMakeLists.txt 
ls
cd build/
ls
cd tex/
ls
cd images/
ls
cd ..
ls
cd. .
cd ..
ls
rm images/fractal.png 
ls
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim CMakeLists.txt 
vim book_main.tex 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim book_main.tex 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim book_main.tex 
cd build/
make
d ..
cd. .
ls
cd ..
ls
clear
ls -l
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
clear
ls -l
cd example-projects/
ls
cd fractals/
ls
vim CMakeLists.txt 
cd ..
cd -
ls
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim CMakeLists.txt +55
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
vim CMakeLists.txt 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim book_main.tex 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim book_main.tex 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim book_main.tex 
imv book_main.tex 
vim book_main.tex 
vim contents/fractals.tex 
vim book_main.tex 
vim contents/fractals.tex 
vim book_main.tex 
vim contents/fractals.tex 
vim book_main.tex 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
cd images/
ls
rm fractal.png 
ls
cd ..
ls
clear
ls -l
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
clear
ls -l
cd build/
ls
cd tex/
ls
cd images/
ls
cd ..
ls
vim CMakeLists.txt 
ls build/
ls
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
cd images/
ls
rm fractal.png 
ls
cd ..
ls
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
ls images/
ls
clear
ls -l
cd build/
ls
cd tex/
ls
cd images/
ls
cd ..
ls
clear
ls -l
cd ..
ls
clear
ls -l
ls
clear
ls -l
git status
vim book_main.tex 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
ls
cd images/
ls
cd ..
ls
cd build/
ls
cd tex/
ls
cd images/
ls
cd ..
ls
clear
ls -l
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim book_main.tex 
cd images/
ls
mv Fractal_fern.png Fractal-fern.png 
ls
cd ..
ls
clear
ls -l
(rm -rf build; mkdir build; cd build; cmake ..; make;)
vim book_main.tex 
(rm -rf build; mkdir build; cd build; cmake ..; make;)
la
ls
clear
ls -l
clear
ls -l
git status
ls
clear
ls -l
vim book_main.tex 
cd build/
make
vim ../book_main.tex 
make
vim ../book_main.tex 
make
vim ../book_main.tex 
make
vim ../book_main.tex 
cd .
cd ..
(rm -rf build; mkdir build; cd build; cmake ..; make;)
clear
ls -l
ls
vim shippable.yml 
exit
git status
ls
clear
ls -l
cd re
cd DO
ls
cd Downloads/
ls
cd ..
ls
clear
ls -l
rm -rf Music/ Pictures/ Videos/ Templates/
ls
clear
ls -l
rm -r Documents/
ls
clear
ls -l
cd Downloads/n
ls
cd Downloads/
ls
clear
ls -l
rm Build1*
ls
clear
ls -l
cd repos/
ls
clear
ls -l
cd sse-book/
ls
clear
ls -l
git checkout master
ls
clear
ls -l
git pull
cd ..
cd. .
cd ..
cd. .
cd. 
cd. .
cd ..
ls 
ls -la
cd ..s
cd .ssh/
ls
cd ..
ls
clear
ls -l
ssh-keygen 
ls
ls -la
vim .ssh/id_rsa.pub 
gedit .ssh/id_rsa.pub 
sudo apt-get remove chromium
sudo apt-get install chromium
sudo apt-cache search chromium
sudo apt-get remove chromium-browser
sudo apt-get install chromium-browser
ls
ls -la
ls
cd Downloads/
ls
rm debian-xterm.desktop 
ls
cd repos/
ls
cd sse-book/
ls
clear
ls -l
git pull
git status
clear
ls -l
git pull
git status
clear
git push
ls
cd ..
ls
clear
ls -l
ls
 ls 
ls -la
cd .ssh/
ls
clear
ls -l
vim known_hosts 
ls
clear
ls -l
cd ..
clear
ls -l
cd Downloads/repos/
ls
cd sse-book/
ls
clear
ls -l
