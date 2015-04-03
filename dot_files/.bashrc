#
# ~/.bashrc: executed by bash(1) for non-login shells.
#

# So we can use cool, neat things:
set nocompatible

# If not running interactively, don't do anything:
[ -z "$PS1" ] && return

# Set dir color:
export LS_COLORS="$LS_COLORS:di=01;94"

# Set editors:
export GIT_EDITOR=vim
export VISUAL=vim
export EDITOR=vim

# Don't put duplicate lines in the history. See bash(1) for more options
export HISTFILESIZE=300000    # save 300000 commands
export HISTCONTROL=ignoredups    # no duplicate lines in the history.
export HISTSIZE=100000

# check the window size after each command and, if necessary,
# update the values of LINES and COLUMNS.
shopt -s checkwinsize
shopt -s histappend
export PROMPT_COMMAND='history -a'

# make less more friendly for non-text input files, see lesspipe(1)
[ -x /usr/bin/lesspipe ] && eval "$(lesspipe)"

# If this is an xterm set the title to user@host:dir
case "$TERM" in
xterm*|rxvt*)
    PROMPT_COMMAND='echo -ne "\033]0;${USER}@${HOSTNAME}: ${PWD/$HOME/~}\007"'
    ;;
*)
    ;;
esac

# Alias definitions.
# You may want to put all your additions into a separate file like
# ~/.bash_aliases, instead of adding them here directly.
# See /usr/share/doc/bash-doc/examples in the bash-doc package.
if [ -f ~/.bash_aliases ]; then
  . ~/.bash_aliases
fi

# enable programmable completion features (you don't need to enable
# this, if it's already enabled in /etc/bash.bashrc and /etc/profile
# sources /etc/bash.bashrc).
if [ -f /etc/bash_completion ]; then
  . /etc/bash_completion
fi

# Functions:
if [ -f ~/.bash_functions ]; then
  . ~/.bash_functions
fi


#
# Prompt:
#   Source: http://mediadoneright.com/content/ultimate-git-ps1-bash-prompt
#

# Source git prompt:
if [ -f ~/.git-prompt.sh ]; then
  . ~/.git-prompt.sh
fi

Time12h="\T"
Time12a="\@"
PathShort="\w"
PathFull="\W"
NewLine="\n"
Jobs="\j"

export PS1=$Purple$Time12h$Color_Off'$(git branch &>/dev/null;\
if [ $? -eq 0 ]; then \
	echo "$(echo `git status` | grep "nothing to commit" > /dev/null 2>&1; \
	if [ "$?" -eq "0" ]; then \
		# @4 - Clean repository - nothing to commit
		echo "'$Green'"$(__git_ps1 " (%s)"); \
	else \
		# @5 - Changes to working tree
	  echo "'$IRed'"$(__git_ps1 " {%s}"); \
	fi) '$BYellow$PathShort$Color_Off'\$ "; \
else \
	# @2 - Prompt when not in GIT repo
	echo " '$Yellow$PathShort$Color_Off'\$ "; \
fi)'


function ii() # get current host related info
{
		Red=$(tput setaf 1)
		Color_Off=$(tput sgr0)

    printf $Red"\nHostname: ${Color_Off}\n${HOSTNAME}\n"
    printf $Red"\nAdditionnal information: "${Color_Off}"\n" ; uname -a
    printf $Red"\nUsers logged on: "${Color_Off}"\n" ; w -h
    printf $Red"\nCurrent date: "${Color_Off}"\n" ; date
    printf $Red"\nMachine stats: "${Color_Off}"\n" ; uptime
    echo
}

#------------------------------------------
#------Extraction of compressed files--------------
# from ARCH Wiki

extract () {
  if [ -f $1 ] ; then
      case $1 in
          *.tar.bz2)   tar xvjf $1    ;;
          *.tar.gz)    tar xvzf $1    ;;
          *.bz2)       bunzip2 $1     ;;
          *.rar)       rar x $1       ;;
          *.gz)        gunzip $1      ;;
          *.tar)       tar xvf $1     ;;
          *.tbz2)      tar xvjf $1    ;;
          *.tgz)       tar xvzf $1    ;;
          *.zip)       unzip $1       ;;
          *.Z)         uncompress $1  ;;
          *.7z)        7z x $1        ;;
          *)           echo "Don't know how to extract '$1'..." ;;
      esac
  else
      echo "'$1' is not a valid file!"
  fi
}

######$########
## SSH Stuff ##
###############

# Note: ~/.ssh/environment should not be used, as it
#       already has a different purpose in SSH.

env=~/.ssh/agent.env

# Note: Don't bother checking SSH_AGENT_PID. It's not used
#       by SSH itself, and it might even be incorrect
#       (for example, when using agent-forwarding over SSH).

agent_is_running() {
    if [ "$SSH_AUTH_SOCK" ]; then
        # ssh-add returns:
        #   0 = agent running, has keys
        #   1 = agent running, no keys
        #   2 = agent not running
        ssh-add -l >/dev/null 2>&1 || [ $? -eq 1 ]
    else
        false
    fi
}

agent_has_keys() {
    ssh-add -l >/dev/null 2>&1
}

agent_load_env() {
    . "$env" >/dev/null
}

agent_start() {
    (umask 077; ssh-agent >"$env")
    . "$env" >/dev/null
}

if ! agent_is_running; then
    agent_load_env
fi

if ! agent_is_running; then
    agent_start
    ssh-add
elif ! agent_has_keys; then
    ssh-add
fi

unset env
