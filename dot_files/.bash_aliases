#
# Bash Aliases
#

# ls
alias ls='ls --color=auto'
alias la='ls -Al'
alias lr='ls -lR'
alias lt='ls -ltr'
alias lm='ls -al | more'
alias ll='ls -lh'
alias lsd='ls -l | grep "^d"'

# 
alias psg='ps -ef | grep $1'
alias h='history | grep $1'
alias path='echo -e ${PATH//:/\\n}'
alias sb='. ~/.bashrc'
alias vi='vim'
alias stamp='date "+%Y%m%d%a%H%M"'
alias da='date "+%Y-%m-%d %A    %T %Z"'

# SSH Machines:
alias quasar='ssh cwherry@quasar.phys.vt.edu'
