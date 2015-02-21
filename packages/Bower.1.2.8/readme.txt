Bower 1.2.8
===========

This package doesn't require node.js and git to be installed on target servers, so it can be easily used in any deployment scenarios (including cloud TFS build services).


Usage
-----

To restore Bower components during build, add the next line to the project pre-build events:

"$(SolutionDir)packages\Bower.1.2.8\bower.cmd" install

Or better use custom .cmd file and run it only after `git pull` (use post-merge and post-rewrite hooks) and on the build server:

@echo off
cmd.exe /c "@echo off & cd %~dp0 & %~dp0..\packages\Bower.1.2.8\bower.cmd install"