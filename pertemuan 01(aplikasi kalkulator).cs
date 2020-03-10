#include <iostream>
using namespace std;

main() {
 char pilih;
 float bil1, bil2, hasil;
 
 cout << " Menu Pilihan Proses" <<endl;
 cout << "===================================" <<endl;
 cout << "[1]. Penjumlahan"<<endl;
 cout << "[2]. Pengurangan"<<endl;
 cout << "[3]. Perkalian"<<endl;
 cout << "[4]. Pembagian"<<endl;
 cout << "===================================" <<endl;
 cout << "input nomor menu [1 .. 4] : ";
 cin >> pilih;
 
 switch(pilih){
  case '1' :
  case 'a' :
   cout << "input nilai a : ";
   cin >> bil1;
   cout << "input nilai b : ";
   cin >> bil2;
   hasil = bil1+bil2;
   cout << "Hasil Penambahan Dari " << bil1 <<"+"<<bil2;
   cout << " Adalah : " << hasil;
   break;
  case '2' :
  case 'b' :
   cout << "input nilai a : ";
   cin >> bil1;
   cout << "input nilai b : ";
   cin >> bil2;
   hasil = bil1-bil2;
   cout << "Hasil Pengurangan Dari " << bil1 <<"-"<<bil2<< " Adalah : " << hasil;
   break;
  case '3' :
  case 'c' :
   cout << "input nilai a : ";
   cin >> bil1;
   cout << "input nilai b : ";
   cin >> bil2;
   hasil = bil1*bil2;
   cout << "Hasil Perkalian Dari " << bil1 <<"*"<<bil2<< " Adalah : " << hasil;
   break;
  case '4' :
  case 'd' :
      cout << "input nilai a : ";
   cin >> bil1;
   cout << "input nilai b : ";
   cin >> bil2;
   hasil = bil1/bil2;
   cout << "Hasil Pembagian Dari " << bil1 <<"/"<<bil2<< " Adalah : " << hasil;
   break;
 }
 
 return 0;
}