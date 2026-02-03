#include<iostream>
#include<vector>
#include<algorithm>
#include<utility>
#include<cmath>
#include<string>
using namespace std;
int N;
void print_gol(int a)
{
	string l(N, '@');
	string s(a * N, ' ');
	string r(N, '@');

	for(int  i =0; i<N; i++)
	{
		if (a != 0)
			cout << l << s << r << "\n";
		else
			cout << string(3 * N, '@') << "\n";
	}
	return;
}
void solution()
{

	cin >> N;

	print_gol(3);
	print_gol(2);
	print_gol(0);
	print_gol(2);
	print_gol(3);

	return;
}

int main()
{
	ios_base::sync_with_stdio(false);
	cout.tie(nullptr);
	cin.tie(nullptr);

	solution();
}