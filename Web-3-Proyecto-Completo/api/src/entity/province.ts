import { IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity,OneToMany,PrimaryGeneratedColumn } from "typeorm";
import { canton } from "./canton";

@Entity()
export class province {
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(100)
    name: string;

    @OneToMany(type => canton, canton => canton.province)
    canton: canton[];
}