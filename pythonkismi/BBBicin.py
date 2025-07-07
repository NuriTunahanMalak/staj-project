import requests
import time
import random
def main():
    while True:
        sicaklik=round(random.uniform(20,30),2)
        veri={
            "sicaklik":sicaklik
        }
        try:
            res1 = requests.post("http://10.11.20.234:5000/api/sicaklik", json=veri)
            res2 = requests.post("http://10.11.20.232:5000/api/sicaklik", json=veri)
            res3 = requests.post("http://10.11.20.95:5000/api/sicaklik", json=veri)

            print("Gönderildi:", sicaklik, "Durumlar:", res1.status_code, res2.status_code, res3.status_code)   
        except Exception as e:
            print("Hata: ",e)
        time.sleep(5)

main()