#include<iostream>
#include<vector>
#include<algorithm>
#include<utility>
#include<cmath>

using namespace std;

int solution()
{
	int T;
	cin >> T;
	while(T--)
	{
		long N, M, K, D;
		cin >> N >> M >> K >> D;

		long a = N * M;
		long b = K * (M - 1) + M*(N - 1);

		long result;
		if( a %2 == 0)
		{
			a /= 2;
			result = a * b;
		}
		else
		{
			b /= 2;
			result = a * b;
		}

		if(result > D)
		{
			cout << -1 << "\n";
			continue;
		}

		cout << result * (D / result) << "\n";
	}
	return  0;
}

int main()
{
	ios_base::sync_with_stdio(false);
	cout.tie(nullptr);
	cin.tie(nullptr);
	solution();
}