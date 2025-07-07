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
            response=requests.post("http://10.11.20.234:5000/api/sicaklik",json==veri)
            print("Gönderildi: ",sicaklik,"Durum: ", response.status_code)
        except Exception as e:
            print("Hata: ",e)
        time.sleep(5)

main()