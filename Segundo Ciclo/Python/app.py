import time
import os

def borrador():
    os.system('cls')

def menu():
	print "===================="
	print "===================="
	print "Welcome to app magic"
	print "===================="
	print "====================" 
	print ""
	print "1. Compra"
	print "2. Factura"
	print ""
	var1 = input("Por favor Ingrese la operacion que decea realizar ");
	borrador ()
	if var1 == 1:
		var2 = raw_input("decea realizar una compra s/n ");
		if var2 == "s":
			compra ()
		elif var2 == "n":
			var3 = raw_input("Decea salir s/n ")
			if var3 == "s":
				salir ()
				menu ()
			if var3 == "n":
				borrador()
				menu()				
	elif var1 == 2:
		var4 = raw_input ("decea realizar factura s/n ");
		if var4  == "s":
			compra ()
		elif var4 == "n":
			var5 = raw_input ("Decea salir s/n ");
			if var5 == "s":
				salir ()
				menu ()				
			elif var5 == "n":
				borrador ()
				menu()
def compra():
	var7 = { "iphonex":10000, "samsung Galaxi 8":5500, "Huawei P20":4200}
	conteo = 0
	for elementos in var7:
		conteo = conteo+1;
		print (str(conteo)+" "+elementos)
	print ""
	var8 = raw_input ("Ingrese el nombre del articulo que desea comprar ")
	print "el precio de " + var8 + " es de " + str(var7[var8])
	var9 = raw_input ("decea comprar el articulo s/n ")
	if var9 == "s":
		var10 = input("Cuantos productos decea comprar ")
		borrador ()
		print "uste tiene que cancelar un total de " + str(var7[var8]*var10)
		var11 = raw_input("Decea cancelar s/n ")
		if raw11 == "s":
			print "se a realizado su pago con exito"
		elif raw11 == "n":
			print	"Vuelva Pronto"
			menu ()	
	elif var9 == "n":
		menu ()

def compra():
	var12 = time.strftime("%d/%m/%y")
	var13 = (time.strftime("%I:%M:%S"))
	print "********* app magic *************"
	print (var13 + " " + var12)
	print "cliente: Nixon Iguardia"
	print "producto: celular "
	print "Precio: 5000.00"
	



def salir():
	var6 = raw_input ("Esta seguro que decea salir s/n ")
	if var6 == "s":
		borrador ()
		print " Su sesion a finalizado"
		time.sleep(3)
	elif var6 == "n":
		menu ()


menu()
			
	