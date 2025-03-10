import { province } from './province';
import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, OneToMany, PrimaryGeneratedColumn } from "typeorm";
import { district } from './district';

@Entity()
export class canton {
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(100)
    name: string;

    @ManyToOne(type => province, province => province.canton)
    province: province;

    @OneToMany(type => district, district => district.canton)
    district: district[];
}