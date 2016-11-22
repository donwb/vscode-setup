export MY_VAR := var-value

console:
	cd console; dotnet run
test:
	cd test; dotnet test
build:
	cd maplib; dotnet build; cd ../console; dotnet build;

.PHONY: console test build
