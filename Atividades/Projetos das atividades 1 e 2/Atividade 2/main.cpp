#include <stdlib.h>
#include <stdio.h>
#include <iostream>

using namespace std;

string getSeq(int a, int b) {
	
	string resp = "";
	if (b >= a) {
		if (b / a > 2) {
			resp = "Nao e possivel criar uma sequencia com essa configuracao dos caracteres.";
		}
		else if (b / a == 2) {
			if (b % a > 2) {
				resp = "Nao e possivel criar uma sequencia com essa configuracao dos caracteres.";
			}
			else {
				for (int i = 0; i < a; i++) {
					resp = resp + "bba";
				}
				if (b % a > 0) {
					for (int i = 0; i < b % a; i++) {
						resp = resp + "b";
					}
				}
			}
		}
		else {
			if (b % a > 3) {
				resp = "Nao e possivel criar uma sequencia com essa configuracao dos caracteres.";
			}
			else {
				if (b % a > 0) {
					resp = resp + "b";
				}
				for (int i = 0; i < a; i++) {
					resp = resp + "ba";
				}
				if (b % a > 1) {
					for (int i = 1; i < b % a; i++) {
						resp = resp + "b";
					}
				}
			}
		}
	}
	else {
		if (a / b > 2) {
			resp = "Nao e possivel criar uma sequencia com essa configuracao dos caracteres.";
		}
		else if (a / b == 2) {
			if (a % b > 2) {
				resp = "Nao e possivel criar uma sequencia com essa configuracao dos caracteres.";
			}
			else {
				for (int i = 0; i < b; i++) {
					resp = resp + "aab";
				}
				if (a % b > 0) {
					for (int i = 0; i < a % b; i++) {
						resp = resp + "a";
					}
				}
			}
		}
		else {
			if (a % b > 3) {
				resp = "Nao e possivel criar uma sequencia com essa configuracao dos caracteres.";
			}
			else {
				if (a % b > 0) {
					resp = resp + "a";
				}
				for (int i = 0; i < a % b; i++) {
					resp = resp + "ab";
				}
				if (a % b > 1) {
					for (int i = 1; i < a % b; i++) {
						resp = resp + "a";
					}
				}
			}
		}
	}

	return resp;
}

int main(){
	int a, b;
	string fim;
	cout << "Insira 2 numeros a seguir. Ex.: a b; x y;\n";
	cout << "Caso queira finalizar, escreva fim.\n";
	while (true) {
		a = b = 0;
		cin >> fim;
		if (fim == "fim") {
			break;
		}
		for (char c : fim) {
			if (c >= '0' && c <= '9') {
				a = a * 10 + (c - '0');
			}
			else {
				cout << "Entrada nao reconhecida\n";
				break;
			}
		}
		cin >> b;
		if ((a == 0) || (b == 0)) {
			cout << "Tente outra combinacao!\n";
		}
		else {
			string resp = getSeq(a, b);
			cout << resp << "\n";
		}
	}


	return 0;
}
