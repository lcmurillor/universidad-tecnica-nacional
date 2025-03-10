import { IsBoolean, IsDate, IsNotEmpty, MaxLength, MinLength } from "class-validator";
import { Column, Entity, ManyToOne, PrimaryGeneratedColumn, Unique } from "typeorm";
import { color } from "./color";
import { marca } from "./marca";
import { tipo_vehiculo } from "./tipo_vehiculo";

@Entity()
@Unique(['placa'])
export class vehiculo{
    /**
     * Llave primaria de la tabla vehiculo.
     */
    @PrimaryGeneratedColumn()
    id: number;
    
    /**
     * Placa de del vehiculo, este atributo es unico y no se puede repetir.
     */
    @Column() @IsNotEmpty() @MinLength(6)  @MaxLength(10)
    placa: string;

    /**
     * Llave foranea donde se relaciona la tabla vehiculo con la tabla marca mediante una relacion de muchos a uno.
     */
    @ManyToOne(type => marca, marca => marca.id)
    id_marca: number;

    /**
     * Llave foranea donde se relaciona la tabla vehiculo con la tabla color mediante una relacion de muchos a uno.
     */
    @ManyToOne(type => color, color => color.id)
    id_color: number;

    /**
     * Atributo que indica el cilindraje del vehiculo.
     */
    @Column() @IsNotEmpty()
    cilindraje: number;

    /**
     * Llave foranea donde se relaciona la tabla vehiculo con la tabla tipo_vehiculo mediante una relacion de muchos a uno.
     */
    @ManyToOne(type => tipo_vehiculo, tipo_vehiculo => tipo_vehiculo.id)
    id_TipoVehiculo: number; 

    /**
     * Cantidad de pasajeros para la que el vehiculo tiene una capacidad maxima.
     */
    @Column() @IsNotEmpty()
    cantidadPasajeros: number;

    /**
     * Fecha en la que el vehiculo fue registrado.
     */
    @Column() @IsNotEmpty() @IsDate()
    fecha_ingreso: Date;

    /**
     * Valor que inica que el vehiculo esta activo o inactivo, siendo estos estados "true" y "false" respectivamente, un vehiculo con estado inactivo no se puede usar en el sistema.
     */
    @Column() @IsNotEmpty() @IsBoolean()
    estado: boolean;
}