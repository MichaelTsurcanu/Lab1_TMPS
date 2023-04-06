# Lab1_TMPS
SOLID este un set popular de principii de proiectare care sunt utilizate în dezvoltarea software-ului orientat pe obiecte. SOLID este un acronim care reprezintă cinci principii cheie de proiectare: principiul responsabilității unice, principiul deschis-închis, principiul substituției Liskov, principiul segregării interfeței și principiul inversării dependenței. Toate cele cinci sunt utilizate în mod obișnuit de inginerii software și oferă câteva beneficii importante pentru dezvoltatori.

Principiile SOLID au fost dezvoltate de Robert C. Martin într-un eseu din 2000, „ Principii de design și modele de design ”, deși acronimul a fost inventat mai târziu de Michael Feathers. În eseul său, Martin a recunoscut că software-ul de succes se va schimba și se va dezvolta. Pe măsură ce se schimbă, devine din ce în ce mai complex. Fără principii bune de design, Martin avertizează că software-ul devine rigid, fragil, imobil și vâscos. Principiile SOLID au fost dezvoltate pentru a combate aceste modele de design problematice.

Scopul larg al principiilor SOLID este de a reduce dependențele, astfel încât inginerii să schimbe o zonă a software-ului fără a afecta altele. În plus, acestea sunt menite să facă design-urile mai ușor de înțeles, întreținut și extins. În cele din urmă, utilizarea acestor principii de proiectare facilitează inginerilor de software să evite problemele și să construiască software adaptabil, eficient și agil.

În timp ce principiile vin cu multe beneficii, respectarea principiilor duce în general la scrierea unui cod mai lung și mai complex. Aceasta înseamnă că poate extinde procesul de proiectare și poate face dezvoltarea puțin mai dificilă. Cu toate acestea, acest timp și efort suplimentar merită, deoarece face software-ul mult mai ușor de întreținut, testat și extins.

Urmarea acestor principii nu este un remediu și nu va evita problemele de design. Acestea fiind spuse, principiile au devenit populare deoarece, atunci când sunt urmate corect, duc la un cod mai bun pentru lizibilitate, întreținere, modele de proiectare și testabilitate. În mediul actual, toți dezvoltatorii ar trebui să cunoască și să utilizeze aceste principii.

Principiul responsabilității unice
Robert Martin rezumă bine acest principiu prin faptul că „o clasă ar trebui să aibă un singur motiv pentru a se schimba”. Urmând acest principiu înseamnă că fiecare clasă face un singur lucru și fiecare clasă sau modul are responsabilitatea doar pentru o parte a funcționalității software-ului. Mai simplu, fiecare clasă ar trebui să rezolve o singură problemă.

Principiul responsabilității unice este un principiu relativ de bază pe care majoritatea dezvoltatorilor îl folosesc deja pentru a construi cod. Poate fi aplicat claselor, componentelor software și microserviciilor.

Utilizarea acestui principiu face codul mai ușor de testat și întreținut, face software-ul mai ușor de implementat și ajută la evitarea efectelor secundare neprevăzute ale schimbărilor viitoare.

Pentru a vă asigura că urmați acest principiu în dezvoltare, luați în considerare utilizarea unei verificări automate a construirii pentru a limita domeniul de aplicare al claselor. Această verificare nu este o modalitate sigură de a vă asigura că urmați principiul responsabilității unice, dar poate fi o modalitate bună de a vă asigura că cursurile nu încalcă acest principiu.

Principiul deschis-închis
Ideea principiului deschis-închis este că clasele existente, bine testate, vor trebui modificate atunci când trebuie adăugat ceva. Cu toate acestea, schimbarea claselor poate duce la probleme sau erori. În loc să schimbi clasa, vrei pur și simplu să o extinzi. Având în vedere acest scop, Martin rezumă acest principiu: „Ar trebui să poți extinde comportamentul unei clase fără a-l modifica.”

Respectarea acestui principiu este esențială pentru scrierea unui cod ușor de întreținut și revizuit. Clasa dvs. respectă acest principiu dacă este:

Deschis pentru extensie, ceea ce înseamnă că comportamentul clasei poate fi extins; și
Închis pentru modificare, ceea ce înseamnă că codul sursă este setat și nu poate fi schimbat.
La prima vedere, aceste două criterii par a fi în mod inerent contradictorii, dar când te simți mai confortabil cu el, vei vedea că nu este atât de complicat pe cât pare. Modul de a respecta aceste principii și de a vă asigura că clasa dvs. este ușor de extins fără a fi nevoie să modificați codul este prin utilizarea abstracțiilor. Utilizarea moștenirii sau a interfețelor care permit substituții polimorfe este o modalitate obișnuită de a respecta acest principiu. Indiferent de metoda folosită, este important să urmați acest principiu pentru a scrie cod care poate fi întreținut și revizuibil.

Principiul substituirii Liskov
Dintre cele cinci principii SOLIDE, Principiul Substituției Liskov este poate cel mai greu de înțeles. În linii mari, acest principiu cere pur și simplu ca fiecare clasă derivată să fie înlocuibilă cu clasa sa părinte. Principiul este numit după Barbara Liskov, care a introdus acest concept de subtipări comportamentale în 1987. Liskov însăși explică principiul spunând:

Ceea ce se dorește aici este ceva de genul următoarei proprietăți de substituție: dacă pentru fiecare obiect O1 de tip S există un obiect O2 de tip T astfel încât pentru toate programele P definite în termeni de T, comportamentul lui P este neschimbat atunci când O1 este substituit pentru O2, atunci S este un subtip de T.

Deși acesta poate fi un principiu dificil de interiorizat, în multe feluri este pur și simplu o extensie a principiului deschis-închis, deoarece este o modalitate de a ne asigura că clasele derivate extind clasa de bază fără a schimba comportamentul.

Respectarea acestui principiu ajută la evitarea consecințelor neașteptate ale modificărilor și evită nevoia de a deschide o clasă închisă pentru a face modificări. Conduce la extensii ușoare ale software-ului și, deși ar putea încetini procesul de dezvoltare, respectarea acestui principiu în timpul dezvoltării poate evita o mulțime de probleme în timpul actualizărilor și extensiilor.

Principiul segregării interfeței
Ideea generală a principiului segregării interfețelor este că este mai bine să aveți o mulțime de interfețe mai mici decât câteva mai mari. Martin explică acest principiu sfătuind: „Creați interfețe cu granulație fină care sunt specifice clientului. Clienții nu ar trebui să fie forțați să implementeze interfețe pe care nu le folosesc.”

Pentru inginerii de software, aceasta înseamnă că nu doriți să începeți doar cu o interfață existentă și să adăugați metode noi. În schimb, începeți prin a construi o nouă interfață și apoi lăsați-vă clasa să implementeze mai multe interfețe după cum este necesar. Interfețele mai mici înseamnă că dezvoltatorii ar trebui să aibă o preferință pentru compoziție față de moștenire și pentru decuplare față de cuplare. Conform acestui principiu, inginerii ar trebui să lucreze pentru a avea mai multe interfețe specifice clientului, evitând tentația de a avea o interfață mare, de uz general.

Principiul inversării dependenței
Acest principiu oferă o modalitate de decuplare a modulelor software. Mai simplu spus, principiul inversării dependenței înseamnă că dezvoltatorii ar trebui să „depindă de abstracții, nu de concreții”. Martin explică în continuare acest principiu afirmând că „modulele de nivel înalt nu ar trebui să depindă de modulele de nivel scăzut. Ambele ar trebui să depindă de abstracții.” În plus, „abstractările nu ar trebui să depindă de detalii. Detaliile ar trebui să depindă de abstracții.”

O modalitate populară de a respecta acest principiu este utilizarea unui model de inversare a dependenței, deși această metodă nu este singura modalitate de a face acest lucru. Indiferent de metoda pe care alegeți să utilizați, găsirea unei modalități de a utiliza acest principiu va face codul dvs. mai flexibil, mai agil și mai reutilizabil.

Concluzie
Implementarea principiilor de proiectare SOLID în timpul dezvoltării va duce la sisteme care sunt mai menținute, scalabile, testabile și reutilizabile. În mediul actual, aceste principii sunt utilizate la nivel global de ingineri. Ca rezultat, pentru a crea un cod bun și pentru a utiliza principii de proiectare care sunt competitive în timp ce îndeplinesc standardele din industrie, este esențial să utilizați aceste principii.

În timp ce implementarea acestor principii poate fi copleșitoare la început, lucrul în mod regulat cu ele și înțelegerea diferențelor dintre codul care respectă principiile și codul care nu le va ajuta la simplificarea și eficientizarea proceselor de proiectare bune.
