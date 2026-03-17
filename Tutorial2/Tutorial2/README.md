Zadanie 5 - Merge bez fast-forward
Tym razem merge nie był fast-forward, bo taki jest możliwy tylko wtedy, gdy na głównej gałęzi nie pojawią się żadne nowe commity. W tym przypadku wykonaliśmy commit na main'ie, nasze gałęzie się rozeszły i wykonaliśmy commit łączący zmiany w obu gałęziach.

Oddanie
1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
Fast-forward kiedy na głównej gałęzi nie powstaną żadne nowe commity od rozgałęziania gałęzi którą mergujemy, a merge commit kiedy od momentu rozgałęzienia wystąpiły już jakieś zmiany.
2. Czym w praktyce różni się merge od rebase?
Przy Merge w historii widzimy dwie gałęzie, które się rozgałęziają i łącza z powrotem (->2 rodziców). Przy Rebase zmiany z drugiej gałęzi są przenoszone do głównej, dzięki czemu mamy jedną gałąź (->jeden rodzic). Rebase wymaga force-pusha.
3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
Podcza merge-commita gałęzi feature-conflict na main, wszystkie zmiany z main zostały zaakceptowane, a zmiany z feature-conflic odrzucone.