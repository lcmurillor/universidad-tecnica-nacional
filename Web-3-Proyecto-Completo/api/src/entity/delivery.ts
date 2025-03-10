import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { OneToMany, OneToOne, PrimaryGeneratedColumn } from "typeorm";
import { delivery_district } from "./delivery_district";
import { Column, Entity, JoinColumn } from "typeorm";
import { user } from "./user";
import { vehicle } from "./vehicle";

@Entity()
export class delivery{
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(1)
    state: string;

    @Column() @IsNotEmpty() @MaxLength(10) @IsDate()
    created_at: string;

    @Column() @IsNotEmpty() @MaxLength(10) @IsDate()
    updated_at: string;

    @OneToOne(type => user)
    @JoinColumn()
    user: user

    @OneToMany(type => vehicle, vehicle => vehicle.delivery)
    vehicle: vehicle[];

    @OneToMany(type => delivery_district, delivery_district => delivery_district.delivery)
    delivery_district: delivery_district[];
}
