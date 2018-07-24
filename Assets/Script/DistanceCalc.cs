using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceCalc : MonoBehaviour {
	public GameObject H2Kanan;
	public GameObject OKiri;
	public GameObject H2;
	public GameObject O;
	public GameObject H2O;
	public GameObject TandaH2O;
	public GameObject H2ODekat;
	public AudioClip suaraH2O;

	public GameObject NaKanan;
	public GameObject ClKiri;
	public GameObject Na;
	public GameObject Cl;
	public GameObject NaCl;
	public GameObject TandaNa;
	public GameObject NaClDekat;
	public AudioClip suaraNaCl;

	public GameObject CKanan;
	public GameObject H4Kiri;
	public GameObject C;
	public GameObject H4;
	public GameObject CH4;
	public GameObject TandaC;
	public GameObject CH4Dekat;
	public AudioClip suaraCH4;

	public GameObject HKanan;
	public GameObject H;
	public GameObject HCl;
	public GameObject TandaH;
	public GameObject HClDekat;
	public AudioClip suaraHCl;

	public GameObject NKanan;
	public GameObject H3Kiri;
	public GameObject N;
	public GameObject H3;
	public GameObject NH3;
	public GameObject TandaN;
	public GameObject NH3Dekat;
	public AudioClip suaraNH3;

	public GameObject O2Kiri;
	public GameObject O2;
	public GameObject CO2;
	public GameObject CO2Dekat;
	public AudioClip suaraCO2;

	public GameObject SiKanan;
	public GameObject Si;
	public GameObject SiO2;
	public GameObject TandaSi;
	public GameObject SiO2Dekat;
	public AudioClip suaraSiO2;

	public GameObject TiKanan;
	public GameObject Ti;
	public GameObject TiO2;
	public GameObject TandaTi;
	public GameObject TiO2Dekat;
	public AudioClip suaraTiO2;

	public GameObject CaKanan;
	public GameObject Ca;
	public GameObject CaO;
	public GameObject TandaCa;
	public GameObject CaODekat;
	public AudioClip suaraCaO;

	public GameObject N2Kanan;
	public GameObject N2;
	public GameObject N2O;
	public GameObject TandaN2;
	public GameObject N2ODekat;
	public AudioClip suaraN2O;


	public GameObject F2Kiri;
	public GameObject F2;
	public GameObject CaF2;
	public GameObject CaF2Dekat;
	public AudioClip suaraCaF2;

	public GameObject tombol;
	public GameObject jarak;
	public GameObject kamera;
	public AudioSource suara;
	public AudioSource deskripsi;

	// Use this for initialization
	void Start () {
		H2.SetActive(true);
		O.SetActive(true);
		Na.SetActive(true);
		Cl.SetActive(true);
		C.SetActive(true);
		H4.SetActive(true);
		H.SetActive(true);
		N.SetActive(true);
		H3.SetActive(true);
		O2.SetActive(true);
		Ti.SetActive(true);
		Si.SetActive(true);
		Ca.SetActive(true);
		N2.SetActive(true);
		F2.SetActive(true);
		H2O.SetActive(false);
		H2ODekat.SetActive(false);
		NaCl.SetActive(false);
		NaClDekat.SetActive(false);
		CH4.SetActive(false);
		CH4Dekat.SetActive(false);
		HCl.SetActive(false);
		HClDekat.SetActive(false);
		NH3.SetActive(false);
		NH3Dekat.SetActive(false);
		CO2.SetActive(false);
		CO2Dekat.SetActive(false);
		TiO2.SetActive(false);
		TiO2Dekat.SetActive(false);
		SiO2.SetActive(false);
		SiO2Dekat.SetActive(false);
		CaO.SetActive(false);
		CaODekat.SetActive(false);
		N2O.SetActive(false);
		N2ODekat.SetActive(false);
		CaF2.SetActive(false);
		CaF2Dekat.SetActive(false);
		tombol.SetActive(false);
		jarak.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		float jarakH2O= Vector3.Distance (H2Kanan.transform.position, OKiri.transform.position);
		float jarakH2Okamera= Vector3.Distance (TandaH2O.transform.position, kamera.transform.position);
		float jarakNaCl= Vector3.Distance (NaKanan.transform.position, ClKiri.transform.position);
		float jarakNakamera= Vector3.Distance (TandaNa.transform.position, kamera.transform.position);
		float jarakCH4= Vector3.Distance (CKanan.transform.position, H4Kiri.transform.position);
		float jarakCkamera= Vector3.Distance (TandaC.transform.position, kamera.transform.position);
		float jarakHCl= Vector3.Distance (HKanan.transform.position, ClKiri.transform.position);
		float jarakHkamera= Vector3.Distance (TandaH.transform.position, kamera.transform.position);
		float jarakNH3= Vector3.Distance (NKanan.transform.position, H3Kiri.transform.position);
		float jarakNkamera= Vector3.Distance (TandaN.transform.position, kamera.transform.position);
		float jarakCO2= Vector3.Distance (CKanan.transform.position, O2Kiri.transform.position);
		float jarakTiO2= Vector3.Distance (TiKanan.transform.position, O2Kiri.transform.position);
		float jarakTikamera= Vector3.Distance (TandaTi.transform.position, kamera.transform.position);
		float jarakSiO2= Vector3.Distance (SiKanan.transform.position, O2Kiri.transform.position);
		float jarakSikamera= Vector3.Distance (TandaSi.transform.position, kamera.transform.position);
		float jarakCaO= Vector3.Distance (CaKanan.transform.position, OKiri.transform.position);
		float jarakCakamera= Vector3.Distance (TandaCa.transform.position, kamera.transform.position);
		float jarakN2O= Vector3.Distance (N2Kanan.transform.position, OKiri.transform.position);
		float jarakN2kamera= Vector3.Distance (TandaN2.transform.position, kamera.transform.position);
		float jarakCaF2= Vector3.Distance (CaKanan.transform.position, F2Kiri.transform.position);

		if (jarakH2O < 2.0) {
			suara.Play();
			H2.SetActive(false);			O.SetActive(false);
			H2O.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Dihidrogen Monoksida";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakH2Okamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakH2Okamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Air";
				H2O.SetActive(false);
				H2ODekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraH2O;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				H2O.SetActive(true);
				H2ODekat.SetActive(false);
			}
		}
		else if (jarakNaCl< 2.0) {
			suara.Play();
			Na.SetActive(false);
			Cl.SetActive(false);
			NaCl.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Natrium Klorida";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakNakamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakNakamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Garam Dapur";
				NaCl.SetActive(false);
				NaClDekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraNaCl;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				NaCl.SetActive(true);
				NaClDekat.SetActive(false);
			}
		}
		else if (jarakCH4< 2.0) {
			suara.Play();
			C.SetActive(false);
			H4.SetActive(false);
			CH4.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Methynol";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakCkamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakCkamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Metana";
				CH4.SetActive(false);
				CH4Dekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraCH4;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				CH4.SetActive(true);
				CH4Dekat.SetActive(false);
			}
		}
		else if (jarakHCl< 2.0) {
			suara.Play();
			H.SetActive(false);
			Cl.SetActive(false);
			HCl.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Hidrogen Klorida";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakHkamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakHkamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Asam Klorida";
				HCl.SetActive(false);
				HClDekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraHCl;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				HCl.SetActive(true);
				HClDekat.SetActive(false);
			}
		}
		else if (jarakNH3 < 2.0) {
			suara.Play();
			N.SetActive(false);
			H3.SetActive(false);
			NH3.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Ammonia";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakNkamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakNkamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Ammonia";
				NH3.SetActive(false);
				NH3Dekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraNH3;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				NH3.SetActive(true);
				NH3Dekat.SetActive(false);
			}
		}
		else if (jarakCO2< 2.0) {
			suara.Play();
			C.SetActive(false);
			O2.SetActive(false);
			CO2.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Karbon Dioksida (s)";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakCkamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakCkamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Dry Ice";
				CO2.SetActive(false);
				CO2Dekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraCO2;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				CO2.SetActive(true);
				CO2Dekat.SetActive(false);
			}
		}
		else if (jarakSiO2< 2.0) {
			suara.Play();
			Si.SetActive(false);
			O2.SetActive(false);
			SiO2.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Silikon Dioksida";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakSikamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakSikamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Kuarsa";
				SiO2.SetActive(false);
				SiO2Dekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraSiO2;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				SiO2.SetActive(true);
				SiO2Dekat.SetActive(false);
			}
		}
		else if (jarakTiO2 < 2.0) {
			suara.Play();
			Ti.SetActive(false);
			O2.SetActive(false);
			TiO2.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Titanium Dioksida";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakTikamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakTikamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Sunscreen";
				TiO2.SetActive(false);
				TiO2Dekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraTiO2;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				TiO2.SetActive(true);
				TiO2Dekat.SetActive(false);
			}
		}
		else if (jarakCaO < 2.0) {
			suara.Play();
			Ca.SetActive(false);
			O.SetActive(false);
			CaO.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Kalsium Monoksida";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakCakamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakCakamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Kapur tohor";
				CaO.SetActive(false);
				CaODekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraCaO;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				CaO.SetActive(true);
				CaODekat.SetActive(false);
			}
		}
		else if (jarakN2O < 2.0) {
			suara.Play();
			N2.SetActive(false);
			O.SetActive(false);
			N2O.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Dinitrogen Monoksida";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakN2kamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakN2kamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Gas Gelak";
				N2O.SetActive(false);
				N2ODekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraN2O;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				N2O.SetActive(true);
				N2ODekat.SetActive(false);
			}
		}
		else if (jarakCaF2< 2.0) {
			suara.Play();
			Ca.SetActive(false);
			F2.SetActive(false);
			CaF2.SetActive(true);
			tombol.GetComponentInChildren<Text>().text= "Kalsium Fluorida";
			jarak.GetComponentInChildren<Text> ().text = Mathf.RoundToInt (jarakCakamera).ToString();
			tombol.SetActive(true);
			jarak.SetActive(true);
			if (jarakCakamera < 50) {
				tombol.GetComponentInChildren<Text>().text= "Fluorit";
				CaF2.SetActive(false);
				CaF2Dekat.SetActive(true);
				if (!deskripsi.isPlaying) {
					deskripsi.clip = suaraCaF2;
					deskripsi.Play();
				}
			} else {
				deskripsi.Stop();
				CaF2.SetActive(true);
				CaF2Dekat.SetActive(false);
			}
		}
		else {
			tombol.SetActive(false);
			jarak.SetActive(false);
			H2.SetActive(true);
			O.SetActive(true);
			H2O.SetActive(false);
			H2ODekat.SetActive(false);

			Na.SetActive(true);
			Cl.SetActive(true);
			NaCl.SetActive(false);
			NaClDekat.SetActive(false);

			C.SetActive(true);
			H4.SetActive(true);
			CH4.SetActive(false);
			CH4Dekat.SetActive(false);

			H.SetActive(true);
			//Cl.SetActive(true);
			HCl.SetActive(false);
			HClDekat.SetActive(false);

			N.SetActive(true);
			H3.SetActive(true);
			NH3.SetActive(false);
			NH3Dekat.SetActive(false);

			//C.SetActive(true);
			O2.SetActive(true);
			CO2.SetActive(false);
			CO2Dekat.SetActive(false);

			Si.SetActive(true);
			//O2.SetActive(true);
			SiO2.SetActive(false);
			SiO2Dekat.SetActive(false);

			Ti.SetActive(true);
			//O2.SetActive(true);
			TiO2.SetActive(false);
			TiO2Dekat.SetActive(false);

			Ca.SetActive(true);
			//O.SetActive(true);
			CaO.SetActive(false);
			CaODekat.SetActive(false);

			N2.SetActive(true);
			//O.SetActive(true);
			N2O.SetActive(false);
			N2ODekat.SetActive(false);

			//Ca.SetActive(true);
			F2.SetActive(true);
			CaF2.SetActive(false);
			CaF2Dekat.SetActive(false);
		}

	}
}
