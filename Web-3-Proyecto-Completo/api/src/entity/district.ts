import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, OneToMany, PrimaryGeneratedColumn } from "typeorm";
import { address } from "./address";
import { canton } from "./canton";
import { delivery_district } from "./delivery_district";

@Entity()
export class district {
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(100)
    name: string;

    @ManyToOne(type => canton, canton => canton.district)
    canton: canton;

    @OneToMany(type => address, address => address.district)
    address: address[];

    @OneToMany(type => delivery_district, delivery_district => delivery_district.district)
    delivery_district: delivery_district[];
}