# Užitočné info

- [Naklonovanie tohto repozitára](#naklonovanie)
- [Prostredie pre praktické ukážky](#prostredie)
- [Zmena adresára cez príkazový riadok](#zmena-adresara)
- [Čo keď mi vyprší prostredie na Katacode?](#vyprsi-prostredie)

<a name="naklonovanie"></a>

## Naklonovanie tohto repozitára

<a name="prostredie"></a>

## Prostredie pre praktické ukážky

Budeme používať online prostredie **Kubernetes Playground** od **Katacoda**: https://www.katacoda.com/courses/kubernetes/playground

Potrebné kroky:

1. Registrácia. Stránka vyžaduje bezplatnú registráciu.

2. Klik na "Start scenario".

![image](images/katacoda1.png)

3. Klik na "launch.sh".

![image](images/katacoda2.png)

V termináli sa potom zobrazí hláška "Kubernetes started".

![image](images/katacoda3.png)

### Lokálna inštalácia (pre odvážnych)

Nasledujúce inštrukcie sú pre tých, ktorí by chceli vedieť, ako sa môžu s Dockerom a Kubernetes hrať aj priamo na svojom počítači. **Pre meetup to ale nie je potrebné -- Katacoda nám bude pre všetky ukážky bohato stačiť.**

Na lokálne spustenie je potrebná inštalácia 3 alebo 4 nástrojov:
- [Docker](https://www.docker.com/) - nástroj pre prácu s kontajnermi
- [kubectl](https://kubernetes.io/docs/reference/kubectl/) - nástroj pre prácu s Kubernetes clusterom cez príkazový riadok
- [k3d](https://k3d.io/v5.2.2/) - lokálny Kubernetes cluster (pod kapotou používa Docker)
- [Lens](https://k8slens.dev) (nepovinné, grafická nadstavba nad kubectl) - nástroj pre prácu s Kubernetes clusterom cez grafické rozhranie

Hlavne inštalácia Dockeru na počítač s Windows môže byť náročnejšia, lebo vyžaduje zapnutú virtualizáciu, a tá sa zapína cez zmenu nastavenia v BIOS-e. Taktiež funguje len na Windows 10 a vyšších.

Potrebné kroky:

1. Nainštalovať Docker: https://docs.docker.com/get-docker/

2. Nainštalovať kubectl: https://kubernetes.io/docs/tasks/tools/#kubectl

3. Nainštalovať k3d: https://k3d.io/v5.2.2/#installation

4. Vytvoriť cluster cez k3d: https://k3d.io/v5.2.2/#quick-start

5. Nainštalovať Lens: https://docs.k8slens.dev/main/getting-started/

6. Vytvoriť si účet pre Lens.

7. Pridať cluster do Lens.

<a name="zmena-adresara"></a>

## Zmena adresára cez príkazový riadok

Na zmenu adresára, v ktorom sa nachádzame, používame príkaz `cd`.

cd .. - presuň ma do adresára o úroveň vyššie

cd demo3-pods - presuň ma do adresára demo3-pods (ktorý sa nachádza v mojom súčasnom adresári)

Príklad 1:

Nachádzam sa v adresári `[nieco]/czechitas-cloud-deployment/demo2-docker`. 

Ak zadám príkaz `cd ..`, presuniem sa do adresára `[nieco]/czechitas-cloud-deployment` (o jeden vyššie).

Príklad 2:

Nachádzam sa v adresári `[nieco]/czechitas-cloud-deployment`.

Ak zadám príkaz `cd demo3-pods`, presuniem sa do adresára `[nieco]/czechitas-cloud-deployment/demo3-pods` (o jeden nižšie).

<a name="vyprsi-prostredie"></a>

## Čo keď mi vyprší prostredie na Katacode?

TODO