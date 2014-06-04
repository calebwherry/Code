colorscheme koehler
syntax on
"filetype on
"au BufNewFile,BufRead *.hpp set filetype=cpp

set nocompatible
set showcmd
set foldmethod=marker

set grepprg=grep\ -nH\ $*

set autoindent
set tabstop=2
set softtabstop=2
set shiftwidth=2

set wildmenu
set wildmode=list:longest,full

set backspace=2

set number

set ignorecase

set smartcase

set incsearch

set hlsearch

set nohidden

set laststatus=2
set statusline='%F%m%r%h%w\ (%{&ff}){%Y}\ [%l,%v][%p%%]'
