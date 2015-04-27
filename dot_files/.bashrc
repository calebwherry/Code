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

# Colors:
if [ -f ~/.bash_colors ]; then
  . ~/.bash_colors
fi

# Functions:
if [ -f ~/.bash_functions ]; then
  . ~/.bash_functions
fi

# Git completion:
if [ -f ~/.git_completion.sh ]; then
  . ~/.git-completion.sh
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
