import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, OneToMany, PrimaryGeneratedColumn } from "typeorm";
import { district } from "./district";
import { user } from "./user";

@Entity()
export class address {
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(20)
    title: string;

    @Column() @IsNotEmpty() @MaxLength(250)
    details: string;

    @Column() @IsNotEmpty() @MaxLength(1)
    state: string;

    @Column() @IsNotEmpty()
    created_at: string;

    @Column() @IsNotEmpty()
    updated_at: string;

    @ManyToOne(type => district, district => district.address)
    district: district;

    @ManyToOne(type => user, user => user.address)
    user: user;
}