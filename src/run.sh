Run() {
	THIS_DIR="$(cd $(dirname $0); pwd)"
	cd "$THIS_DIR"
	csc -nologo "./StdIn.cs"
	chmod +x "./StdIn.exe"
	echo -e "A\n\tB" | "./StdIn.exe"
# 永久待機……
	"./StdIn.exe"
}
Run "$@"
