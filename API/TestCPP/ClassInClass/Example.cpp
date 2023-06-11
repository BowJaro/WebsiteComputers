#include <iostream>

using namespace std;

class MachDien {
public:
	virtual void nhap();
};

void MachDien::nhap() { return; }

class DienTro : public MachDien{
private:
	string ten;
	int dienTro;

public:
	void nhap();
};

void DienTro::nhap() {
	cout << "Nhap ten: "; 
	cin >> ten;
	
	cout << "Nhap dien tro: "; 
	cin >> dienTro;
}

class MachSongSong: public MachDien{
private:
	int soMachCon;
	MachDien* dsMachCon[100];

public:
	void nhap();
};

void MachSongSong::nhap() {
	cout << "Nhap so mach con: ";
	cin >> soMachCon;

	int luaChon;
	cout << "Nhap thong tin cac mach con trong mach song song: \n";
	for (int i = 0; i < soMachCon; i++) {
		cout << "Mach con " << i << ":"
			<< "\n- Chon loai mach con:"
			<< "\n    0. Dien tro"
			<< "\n    1. Mach song song"
			<< "\n    2. Mach noi tiep"
			<< "  Lua chon cua ban: ";
		cin >> luaChon;

		switch (luaChon) {
		case 0:
			dsMachCon[i] = new DienTro;
			break;
		case 1:
			dsMachCon[i] = new MachSongSong;
			break;
		case 2:
			dsMachCon[i] = new MachNoiTiep;
			break;
		}
		
		dsMachCon[i]->nhap();
	}
}

class MachNoiTiep: public MachDien{
private:
	int soMachCon;
	MachDien* dsMachCon[100];

public:
	void nhap();
};

void MachNoiTiep::nhap() {
	cout << "Nhap so mach con: ";
	cin >> soMachCon;

	int luaChon;
	cout << "Nhap thong tin cac mach con trong mach noi tiep: \n";
	for (int i = 0; i < soMachCon; i++) {
		cout << "Mach con " << i << ":"
			<< "\n- Chon loai mach con:"
			<< "\n    0. Dien tro"
			<< "\n    1. Mach song song"
			<< "\n    2. Mach noi tiep"
			<< "  Lua chon cua ban: ";
		cin >> luaChon;

		switch (luaChon) {
		case 0:
			dsMachCon[i] = new DienTro;
			break;
		case 1:
			dsMachCon[i] = new MachSongSong;
			break;
		case 2:
			dsMachCon[i] = new MachNoiTiep;
			break;
		}

		dsMachCon[i]->nhap();
	}
}

int main() {
	MachDien* mach = new MachDien;

	mach->nhap();

	return 0;
}