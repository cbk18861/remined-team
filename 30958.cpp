#include<iostream>
#include<vector>
#include<algorithm>
#include<utility>
#include<cmath>
#include<string>
using namespace std;
vector<int> alpha(26);
int solution()
{
	int N;
	cin >> N;
	cin.ignore();
	string s;
	getline(cin, s);
	for(int  i=0; i< N; i++)
	{
		if (s[i] != ' ' && s[i] != ',' && s[i] != '.')
			alpha[s[i] - 'a']+=1;
	}

	return *max_element(alpha.begin(), alpha.end());
}

int main()
{
	ios_base::sync_with_stdio(false);
	cout.tie(nullptr);
	cin.tie(nullptr);

	cout << solution();
}