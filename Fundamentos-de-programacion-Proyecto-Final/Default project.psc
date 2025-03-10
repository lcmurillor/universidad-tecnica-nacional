Proceso Proyecto
	Definir x Como cadena;
	Definir num como entero;
	Definir matriz,matriz2,vector Como Cadena;
	Dimension matriz[40,40];
	Dimension matriz2[40,40];
	Dimension vector[54];
	LlenarMatriz(matriz);
	LlenarMatriz(matriz2);
	LlenarVector(vector);
	Repetir
		Limpiar Pantalla;
		MostrarAlmacenamiento(matriz);
		Escribir "-------------------------------------------------------------------";
		Escribir "|--| MENU DE OPCIONES |-------------------------------------------|";
		Escribir "-------------------------------------------------------------------";
		Escribir "|          1.    [Ingreser un nuevo Archivo]                      |";
		Escribir "|          2.    [Ver la Matriz]                                  |";
		Escribir "|          3.    [Eliminar un Archivo]                            |";
		Escribir "|          4.    [Buscar un archivo]                              |";
		Escribir "|          5.    [Mostrar y restaurar]                            |";
		Escribir "|          6.    [Lista de archivos]                              |";
		Escribir "|          7.    [Desfragmentar]                                  |";
		Escribir "|          8.    [Optimizar]                                      |";
		Escribir "|          9.    [Cargar la matriz (Solo para pruebas)]           |";
		Escribir "|          0.    [Salir]                                          |";
		Escribir "-------------------------------------------------------------------";
		Leer x;
		Limpiar Pantalla;
		Si x="0" o x="1" o x="2" o x="3" o x="4" o x="5" o x="6" o x="7" o x="8" o x="9" Entonces
			num<-ConvertirANumero(x);
		SiNo
			MostrarAlmacenamiento(matriz);
			Escribir "¡Invalido, intentelo de nuevo!";
			Esperar 2 segundos;
			num<-10;
		FinSi 
		Segun num Hacer
			1:
				AgregarArchivo(matriz);
			2: 
				MostrarMatriz(matriz);
			3:
				EliminarArchivos(matriz);
			4:
				BuscarArchivo(matriz);
			5:
				ValidacionDePapelera(matriz,matriz2,vector);
			6:
				ValidacionListaDeArchivos(matriz,matriz2,vector);
			7:
				Desfragmentar(matriz,matriz2,vector);
			8:
				Optimizar(matriz);
			9:
				ValidacionDeLLenarMatriz(matriz);
			0:
				MostrarAlmacenamiento(matriz);
				Escribir "Cerrando proyecto...";
				Esperar 2 segundos;
		FinSegun
	Hasta Que num=0;
FinProceso
SubProceso LlenarMatriz(matriz)
	Definir f,c Como Entero;
	Para f<-0 Hasta 39 hacer
		Para c<-0 Hasta 39 hacer
			matriz[f,c]<-"(   )";
		FinPara
	FinPara
FinSubProceso
SubProceso LlenarVector(vector)
	Definir i como entero;
	Para i<-0 hasta 53 hacer 
		Vector[i]<-"0";
	FinPara
FinSubProceso
SubProceso MostrarMatriz(matriz)
	Definir f,c Como Entero;
	MostrarAlmacenamiento(matriz);
	Para f<-0 Hasta 39  Hacer
		Para c<-0 Hasta 39  Hacer
			Escribir Sin Saltar matriz[f,c];
		FinPara
		Escribir " ";
	FinPara
	Esperar tecla;
FinSubProceso
SubProceso LlenarVectorConCaracteres(vec)
	vec[0]<-"Aa";vec[9]<-"Jj";vec[18]<-"Rr";					
	vec[1]<-"Bb";vec[10]<-"Kk";vec[19]<-"Ss";				
	vec[2]<-"Cc";vec[11]<-"Ll";vec[20]<-"Tt";				
	vec[3]<-"Dd";vec[12]<-"Mm";vec[21]<-"Uu";					
	vec[4]<-"Ee";vec[13]<-"Nn";vec[22]<-"Vv";					
	vec[5]<-"Ff";vec[14]<-"Ññ";vec[23]<-"Ww";						
	vec[6]<-"Gg";vec[15]<-"Oo";vec[24]<-"Xx";					
	vec[7]<-"Hh";vec[16]<-"Pp";vec[25]<-"Yy";				
	vec[8]<-"Ii";vec[17]<-"Qq";vec[26]<-"Zz";
FinSubProceso
SubProceso nombrevalido<-NombresValidosPorCaracter(nom)
	Definir vec como cadena;
	Dimension vec[27];
	LlenarVectorConCaracteres(vec);			
	Definir i como entero;
	Definir nombrevalido como logico;
	nombrevalido<-Falso;
	Para i<-0 hasta 26 con paso 1 hacer
		Si nom=Subcadena(vec[i],0,0) o nom=Subcadena(vec[i],1,1) Entonces
			nombrevalido<-verdadero;
		FinSi
	FinPara
FinSubProceso
SubProceso condi<-ValidacionDelNombreExistente(nom,matriz)
	Definir f,c Como Entero;
	Definir condi como logico;
	condi<-Verdadero;
	Para f<-0 Hasta 39 Hacer
		Para c<-0 Hasta 39  Hacer
			Si nom = Subcadena(matriz[f,c],1,1) && Subcadena(matriz[f,c],0,0)="[" Entonces
				condi<-Falso;
			SiNo
			FinSi
		FinPara
	FinPara
FinSubProceso
SubProceso AgregarArchivo(matriz)
	Definir nomarch,numtxt,nom Como Cadena;
	Definir cont, num Como Entero;
	Definir condi, nombrevalido como logico;
	Repetir 
		MostrarAlmacenamiento(matriz);
		Escribir "Ingrese el nombre del archivo";
		Leer nom;
		nombrevalido<-NombresValidosPorCaracter(nom);
		condi<-ValidacionDelNombreExistente(nom,matriz);
		Si condi= verdadero && nombrevalido=Verdadero Entonces
			Repetir
				Limpiar Pantalla;
				MostrarAlmacenamiento(matriz);
				Escribir "Ingrese el nombre del archivo";
				Escribir nom;
				Escribir "Ingresar el tamaño";
				leer num;	
				Si num>99 Entonces
					Escribir "¡El tamaño del dato no puede ser mayor a 99!";
				SiNo
					Si num<0 Entonces 
						Escribir "¡El tamaño del dato no puede ser negativo!";
					SiNo
						Si num=0 Entonces 
							Escribir "¡El tamaño no puede ser de 0!";
						SiNo
							Escribir "Archivo guardado con exito";
						FinSi
					FinSi
				FinSi
				Esperar 2 segundos;	
				Limpiar Pantalla;
			Hasta Que num>=1 && num<=99
			Para cont<-1 Hasta num Con Paso 1 Hacer
				Si cont<= 9 Entonces 
					numtxt<-Convertiratexto(cont);
					numtxt<-Concatenar("0",numtxt);
				SiNo
					numtxt<-Convertiratexto(cont);
				FinSi
				nomarch<-Concatenar(Concatenar("[",Concatenar(nom,numtxt)),"]");
				CargarMatriz(matriz,nomarch);
			FinPara
		SiNo
			Si condi = Falso Entonces  
				Escribir "¡Ese nombre NO esta disponible!";
				Escribir "¡Un archivo ya dispone de ese nombre!";
			FinSi
			Si nombrevalido = falso Entonces
				Escribir "¡El Caracter es invalido!";
				Escribir"¡El nombre debe ser una letra de la A a la Z!";
			FinSi
			Esperar 2 segundos;	
		FinSi
		Limpiar Pantalla;
	Hasta Que condi=Verdadero && nombrevalido=verdadero
FinSubProceso
SubProceso CargarMatriz(matriz,nomarch)
	Definir f,c Como Entero;
	Para f<-0 Hasta 39  Hacer
		Para c<-0 Hasta 39  Hacer
			Si Subcadena(matriz[f,c],0,0)="(" Entonces
				matriz[f,c]<-nomarch;
				f<-39;
				c<-39;
			FinSi
		FinPara
	FinPara
FinSubProceso
SubProceso EliminarArchivos(matriz)
	Definir f,c,b como entero;
	Definir nomarch,archtemp como cadena;
	Definir bandera Como Logico;
	MostrarAlmacenamiento(matriz);
	bandera<-Falso;
	Para f<-0 hasta 39 hacer 
		Para c<-0 hasta 39 hacer 
			Si Subcadena(matriz[f,c],1,3)!="   " Entonces 
				Bandera<-Verdadero;
			FinSi
		FinPara
	FinPara
	Si bandera = Verdadero Entonces
		Repetir
			Limpiar Pantalla;
			MostrarAlmacenamiento(matriz);
			Escribir "Ingrese el nombre del archivo que desea eliminar";
			leer nomarch;
			b<-2;
			Para f<- 0 hasta 39  hacer 
				para c<-0 hasta 39  hacer
					Si nomarch = Subcadena(matriz[f,c],1,1) Entonces
						Si Subcadena(matriz[f,c],0,0)="[" Entonces
							archtemp<-Subcadena(matriz[f,c],1,3);
							archtemp<-Concatenar(Concatenar("(",archtemp),")");
							matriz[f,c]<-archtemp;
							b<-0;
						SiNo
							b<-1;
						FinSi
					FinSi
				FinPara
			FinPara
			Si b=1 Entonces
				Escribir "El archivo ya ha sido eliminado anteriormente";
			SiNo
				Si b=0 Entonces
					Escribir "El archivo fue eliminado con exito";
				SiNo
					Escribir "¡Ese nombre no corresponde a ningun archivo!";
				FinSi
			FinSi
			Esperar 2 segundos;
		Hasta Que b!=2
	SiNo
		Escribir "¡No hay archivos que se pueden eliminar!";
		Esperar 2 Segundos;
	FinSi
FinSubProceso
SubProceso BuscarArchivo(matriz)
	Definir nomarch como cadena;
	Definir f,c,cont como entero;
	MostrarAlmacenamiento(matriz);
	Escribir "Ingrese el nombre del archivo";
	leer nomarch;
	cont<-0;
	Para f<-0 hasta 39 hacer
		Para c<-0 hasta 39 Hacer
			Si nomarch=Subcadena(matriz[f,c],1,1) && Subcadena(matriz[f,c],0,0)="[" Entonces
				cont<-cont+1;
			FinSi
		FinPara
	FinPara
	Si cont!= 0 Entonces
		Escribir "El nombre del archivo es: ",nomarch;
		Escribir "El tamaño es de: ",cont;
		Esperar tecla;
	SiNo
		Escribir "El nombre: ",nomarch," NO corresponde a ningun archivo";
		Esperar 3 segundos;
		Limpiar Pantalla;
	FinSi
FinSubProceso
SubProceso ValidacionDePapelera(matriz,matriz2,vector)
	Definir f,c,bandera como entero;
	bandera<-0;
	para f<-0 hasta 39 hacer 
		para c<-0 hasta 39 Hacer
			Si Subcadena(matriz[f,c],2,4)="01)" Entonces
				bandera<-1;
			FinSi
		FinPara
	FinPara
	Si bandera=0 Entonces
		MostrarAlmacenamiento(matriz);
		Escribir "¡No hay archivos que se puedan restaurar!";
		Esperar 2 segundos;
	FinSi
	Si bandera=1 Entonces
		MostrarYRestaurar(matriz,matriz2,vector);
	FinSi
FinSubProceso
SubProceso MostrarYRestaurar(matriz,matriz2,vector)
	Definir f,c,cont,i,x,band como entero;
	Definir nomarch,nomrecu como cadena;
	Definir nombrevalido Como Logico;
	Repetir
		MostrarAlmacenamiento(matriz);
		Escribir "Lista de archivos eliminados";
		BanderasYDesfragmentacion(matriz,matriz2,vector);
		i<-0;
		Mientras vector[i]!="0" Hacer
			Si Subcadena(vector[i],4,4)="E" Entonces
				Escribir "El nombre del archivo es: ",Subcadena(vector[i],0,0)," Tamaño: ",Subcadena(vector[i],1,2);
			FinSi
		i<-i+1;
		FinMientras
		Escribir " ";
		Escribir "¿Que archivo desea recuperar?";
		leer nomrecu;
		nombrevalido<-NombresValidosPorCaracter(nomrecu);
		band<-0;
		Para x<-0 hasta 53 Hacer
			Si nomrecu = Subcadena(vector[x],0,0) Entonces 
				band<-1;
			FinSi
		FinPara
		Si nombrevalido = falso o band=0 Entonces
			Escribir "¡El caracter es incorrecto, no correspone a ningun archivo!";
			Escribir "¡El nombre no corresponde a ningun archivo que se pueda recuperar!";
			Esperar 4 segundos;
			Limpiar Pantalla;
		SiNo
			Si band = 1 && nombrevalido = Verdadero Entonces
				Restaurar(matriz,matriz2,nomrecu,vector);
			FinSi	
		FinSi
	Hasta Que nombrevalido = verdadero && band=1
FinSubProceso
SubProceso Restaurar(matriz,matriz2,nomrecu,vector)
	Definir i,x,cont,num,f,c como entero;
	Definir numtxt,nomarch,nom como cadena;
	i<-0;
	Mientras nomrecu!=Subcadena(vector[i],0,0) hacer
		i<-i+1;
	FinMientras
	nom<-nomrecu;
	Si Subcadena(vector[i],1,1)="0" Entonces
		num<-ConvertirANumero(Subcadena(vector[i],2,2));
	SiNo
		num<-ConvertirANumero(Subcadena(vector[i],1,2));
	FinSi
	Para cont<-1 Hasta num Hacer
		Si cont<= 9 Entonces 
			numtxt<-Convertiratexto(cont);
			numtxt<-Concatenar("0",numtxt);
		SiNo
			numtxt<-Convertiratexto(cont);
		FinSi
		nomarch<-Concatenar(Concatenar("[",Concatenar(nom,numtxt)),"]");
		Para f<-0 Hasta 39  Hacer
			Para c<-0 Hasta 39  Hacer
				Si Subcadena(matriz[f,c],0,0)="(" && Subcadena(matriz[f,c],1,1)=nom Entonces
					matriz[f,c]<-nomarch;
					f<-39;
					c<-39;
				FinSi
			FinPara
		FinPara
	FinPara
	Escribir "El archivo fue recuperado";
	Esperar 2 segundos;
FinSubProceso
SubProceso ValidacionDeLLenarMatriz(matriz)
	Definir num como entero;
	MostrarAlmacenamiento(matriz);
	Si matriz[0,0]="(   )" Entonces
		Repetir
			Limpiar Pantalla;
			MostrarAlmacenamiento(matriz);
			escribir "1.    Para cargar la matriz de forma automatica";
			Escribir "2.    Ejemplo de Fragmentacion";
			leer num;
			Segun num hacer
				1:
					Si matriz[0,0]="(   )" Entonces
						Escribir "Cargando la matriz...";
						Escribir "Por favor espere, esto puede tardar un tiempo";
						LlenarMatrizAzar(matriz);
					FinSi
				2:
					Escribir "La matriz fue fragmentada";
					Esperar 2 segundos;
					MatrizFragmentadaDePrueba(matriz);
				De Otro Modo:
					Escribir "¡Varriable invalida!";
					Esperar 2 segundos;
			FinSegun
		Hasta Que num=1 o num=2
	SiNo
		Escribir "¡La Matriz ya ha sido cargada de manera automatica";
		Escribir "con esta funcion o de manera manual!";
		Esperar 4 segundos;
	FinSi
FinSubProceso
SubProceso LlenarMatrizAzar(matriz)
	Definir f,c,ff,cc,i,cont,num como entero;
	Definir vec,numtxt,nomarch,nom como cadena;
	Definir bandera como logico;
	Dimension vec[27];
	LlenarVectorConCaracteres(vec);
	i<-0;
	Repetir
		Para f<-0 hasta 39 Hacer
			Para c<-0 hasta 39 Hacer
				nom<-Subcadena(vec[i],0,0);
				i<-i+1;
				Si i=27 Entonces
					f<-39;c<-39;
				FinSi
				num<-azar(99)+1;
				Para cont<-1 Hasta num Hacer
					Si cont<= 9 Entonces 
						numtxt<-Convertiratexto(cont);
						numtxt<-Concatenar("0",numtxt);
					SiNo
						numtxt<-Convertiratexto(cont);
					FinSi
					nomarch<-Concatenar(Concatenar("[",Concatenar(nom,numtxt)),"]");
					bandera<-CargarMatrizMedianteaAzar(matriz,nomarch);
				FinPara
			FinPara
		FinPara
	Hasta Que bandera=verdadero o i=27
FinSubProceso
SubProceso bandera<-CargarMatrizMedianteaAzar(matriz,nomarch)
	Definir f,c Como Entero;
	Definir bandera como logico;
	bandera<-Falso;
	Si matriz[39,39]="(   )" Entonces
		Para f<-0 Hasta 39  Hacer
			Para c<-0 Hasta 39  Hacer
				Si Subcadena(matriz[f,c],0,0)="(" Entonces
					matriz[f,c]<-nomarch;
					f<-39;
					c<-39;
				FinSi
			FinPara
		FinPara
	SiNo
		bandera<-Verdadero;
	FinSi
FinSubProceso
Subproceso	MatrizFragmentadaDePrueba(matriz)
	matriz[0,0]<-'[B01]';matriz[0,8]<-'[C02]';
	matriz[0,1]<-'[B02]';matriz[0,9]<-'[C03]';
	matriz[0,2]<-'[A01]';matriz[0,10]<-'[C04]';
	matriz[0,3]<-'[A02]';matriz[0,11]<-'[A04]';
	matriz[0,4]<-'[A03]';matriz[0,12]<-'[A05]';
	matriz[0,5]<-'[B03]';matriz[0,13]<-'[B05]';
	matriz[0,6]<-'[B04]';matriz[0,14]<-'[B06]';
	matriz[0,7]<-'[C01]';matriz[0,15]<-'[B07]';
FinSubProceso
SubProceso ValidacionListaDeArchivos(matriz,matriz2,vector)
	MostrarAlmacenamiento(matriz);
	Si matriz[0,0]="(   )" Entonces
		Escribir "¡No hay archivos!";
		Esperar 2 segundos;
	SiNo
		Limpiar Pantalla;
		ListaDeArchivos(matriz,matriz2,vector);
	FinSi
FinSubProceso
SubProceso ListaDeArchivos(matriz,matriz2,vector)
	Definir i,num como entero;
	MostrarAlmacenamiento(matriz);
	BanderasYDesfragmentacion(matriz,matriz2,vector);
	i<-0;
	Mientras vector[i]!="0" Hacer
		Escribir "El nombre del archivo es: ",Subcadena(vector[i],0,0)," Tamaño: ",Subcadena(vector[i],1,2);
		Si Subcadena(vector[i],1,1)="0" Entonces
			num<-ConvertirANumero(Subcadena(vector[i],2,2));
		SiNo
			num<-ConvertirANumero(Subcadena(vector[i],1,2));
		FinSi
		Escribir "Espacio usado por el archivo: ",(num/1600)*100,"%";
		Si Subcadena(vector[i],3,3)="D"  Entonces
			Escribir "Desfragmentado";
		SiNo
			Escribir "Fragmentado";
		FinSi
		Si Subcadena(vector[i],4,4)="A"  Entonces
			Escribir "Activo";
		SiNo
			Escribir "Eliminado";
		FinSi
		i<-i+1;
		Esperar Tecla;
	FinMientras
FinSubProceso
SubProceso MostrarAlmacenamiento(matriz)
	definir c1,c2,c3,c4,f,c como entero;
	c1<-0;c2<-0;c3<-0;c4<-0;
	Para f<-0 hasta 39 Hacer
		Para c<-0 hasta 39 Hacer
			Si subcadena(matriz[f,c],0,0)="(" && subcadena(matriz[f,c],1,1)<>" " entonces;
				c1<-c1+1;
		 	FinSi
			Si subcadena(matriz[f,c],0,0)="[" entonces;
				c2<-c2+1;
			FinSi
			Si subcadena(matriz[f,c],0,4)="(   )" entonces;
				c3<-c3+1;
			FinSi
			Si subcadena(matriz[f,c],0,0)="(" Entonces
				c4<-c4+1;
			FinSi
		FinPara
	FinPara  
	Escribir "---------------------------------------";
	Escribir "|Espacio archivos: ",(c2/1600)*100,"%";
	Escribir "|Espacio en archivos eliminados: ",(c1/1600)*100,"%";
	Escribir "|Espacio disponible: ",(c4/1600)*100,"%";
	Escribir "|Espacio  libre: ",(c3/1600)*100,"%";
	Escribir "---------------------------------------";
FinSubProceso
SubProceso Desfragmentar(matriz,matriz2,vector)
	Definir f,c como entero;
	MostrarAlmacenamiento(matriz);
	BanderasYDesfragmentacion(matriz,matriz2,vector);
	Para f<-0 hasta 39 Hacer
		Para c<-0 hasta 39 Hacer
			matriz[f,c]<-matriz2[f,c];
		FinPara
	FinPara
	Escribir "La matriz ha sido desfragmentada";
	Esperar 2 segundo;
FinSubProceso
SubProceso BanderasYDesfragmentacion(matriz,matriz2,vector)
	Definir f,c,f2,c2,f3,c3,cont,conti Como Entero;
	Definir nombrearch,estadoarch,estadoarch2,numtxt  como Cadena;
	Definir bandera, banderaF como logico;
	LlenarVector(vector);
	f3<-0;
	c3<-0;
	conti<-0;
	bandera<-falso;
	Para f<-0 hasta 39 hacer
		Para c<-0 hasta 39 Hacer
			Si Subcadena(matriz[f,c],2,3) = "01" Entonces
				nombrearch<-Subcadena(matriz[f,c],1,1);
				cont<-0;
				bandera<-Verdadero;
				banderaF<-falso;
				Si subcadena(matriz[f,c],0,0)="[" Entonces
					estadoarch2<-"A";
				SiNo
					estadoarch2<-"E";
				FinSi
				Para f2<-f hasta 39 Hacer
					Para c2<-c hasta 39 Hacer
						Si nombrearch = Subcadena(matriz[f2,c2],1,1) Entonces
							matriz2[f3,c3]<-matriz[f2,c2];
							c3<-c3+1;
							cont<-cont+1;
							Si bandera = falso Entonces
								banderaF<-verdadero;
							FinSi
							Si c3 > 39 Entonces
								c3<-0;
								f3<-f3+1;
							FinSi
						FinSi
						Si nombrearch != Subcadena(matriz[f2,c2],1,1) Entonces
							bandera<-falso;
						FinSi
					FinPara
				FinPara
				Si banderaF = verdadero Entonces
					estadoarch<-"F";
					
				SiNo
					estadoarch<-"D";
				FinSi
				Si cont<10 Entonces 
					numtxt<-Convertiratexto(cont);
					numtxt<-Concatenar("0",numtxt);
				SiNo
					numtxt<-Convertiratexto(cont);
				FinSi
				nombrearch<-Concatenar(nombrearch,numtxt);
				nombrearch<-Concatenar(nombrearch,estadoarch);
				nombrearch<-Concatenar(nombrearch,estadoarch2);
				vector[conti]<-nombrearch;
				conti<-conti+1;
			FinSi
		FinPara
	FinPara
FinSubProceso
Subproceso Optimizar(matriz)
	Definir f,c,x como entero;
	Definir p,m,i Como Entero;
	Definir vector,t como cadena;
	MostrarAlmacenamiento(matriz);
	Dimension vector[1600];
	Escribir "Optimizando...";
	Escribir "Por favor espere, esto puede tardar un tiempo";
	x<-0;
	para f<-0 hasta 39 hacer 
		para c<-0 hasta 39 hacer
			vector[x]<-matriz[f,c];
			x<-x+1;
		FinPara
	FinPara
	Para i<-0 hasta 1599 Hacer
		m<-i;
		Para p<-(i+1) hasta 1599 Hacer
			Si vector[m]>vector[p] Entonces
				m<-p;
			FinSi
		FinPara
		t<-Vector[m];
		Vector[m]<-Vector[i];
		Vector[i]<-t;
	FinPara
	LlenarMatriz(matriz);
	c<-0;
	f<-0;
	Para x<-0 hasta 1599 Hacer
		Si Subcadena(vector[x],0,0)="[" Entonces
			matriz[f,c]<-vector[x];
			c<-c+1;
			Si c>39 Entonces
				f<-f+1;
				c<-0;
			FinSi
		FinSi
	FinPara
FinSubProceso
