import requests
from fastapi import FastAPI
from fastapi.middleware.cors import CORSMiddleware
import sqlite3
import json
import urllib.request
import datetime
from datetime import date

app = FastAPI()
origins = ["*"]

app.add_middleware(
    CORSMiddleware,
    allow_origins=origins,
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)


@app.get('/api')
def read_root():
    return {'detail': 'Welcome to this app'}

@app.get('/api/Registrar_R/{cedula}/{des_robo}/{valor}/{lugar}/{latitud}/{longitud}')
def Registrar_P(cedula: str, des_robo: str, valor: str, lugar: str,latitud:str,longitud:str):
    conexion=sqlite3.connect('app.db')
    registro=conexion.cursor()
    respuesta = urllib.request.urlopen('https://api.adamix.net/apec/cedula/'+cedula+'')
    data = json.loads(respuesta.read())     
    try:
        info= (data['Cedula'],data['Nombres'],data['Apellido1'],datetime.datetime.strptime(data['FechaNacimiento'], '%Y-%m-%d %H:%M:%S.%f').date(),des_robo,lugar,longitud,longitud,valor)
        sql=''' INSERT INTO ROBO(CEDULA,NOMBRE,APELLIDO,FECHA_N,DES_ROBO,PROVINCIA,LATITUD,LONGITUD,VALOR) VALUES (?,?,?,?,?,?,?,?,?) '''
        registro.execute(sql,info)
        conexion.commit()
        return {"mensaje": "Registro Exitoso"}
    except:
        return{"mensaje":"Cedula invalida"}

@app.get('/api/EDITAR_R/{campo}/{cambio}/{id}')
def EDITAR_R(campo: str, cambio: str, id: str):
    conexion=sqlite3.connect('app.db')
    registro=conexion.cursor()
    registro.execute("UPDATE ROBO SET "+campo+"='"+cambio+"' WHERE ID_ROBO= '"+id+"' ")
    conexion.commit()
    return {"mensaje":"Actulizacion Completada Exitosamente!"}

@app.get('/api/Provinvias')
def Provinvias():
    a=[]
    conexion=sqlite3.connect('app.db')
    registro=conexion.cursor()
    data = registro.execute("SELECT * FROM PROVINCIAS")
    conexion.commit()
    datos = data.fetchall()
    for i in datos:
        a.append({"ID":[0],"NOMBRE": i[1]})
    return a







    




    











            



