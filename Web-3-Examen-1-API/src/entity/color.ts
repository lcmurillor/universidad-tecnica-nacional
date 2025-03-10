import { IsBoolean, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class color{

    /**
     * llave primaria de la tabla color.
     */
    @PrimaryGeneratedColumn()
    id: number;

    /**
     * Nombre del color de los vehicuilos.
     */
    @Column() @IsNotEmpty() @MaxLength(30)
    nombre: string;

    /**
     * Valor que inica que el color esta activo o inactivo, siendo estos estados "true" y "false" respectivamente, un color con estado inactivo no se puede usar en el sistema.
     */
    @Column() @IsNotEmpty() @IsBoolean()
    estado: boolean;
}