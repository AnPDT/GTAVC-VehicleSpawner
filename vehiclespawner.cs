         2� V �� M �����     M ����
  ��  �sM �����  9   M ����   �  9   M |���  � �  9  M b���  � �  9  M H���  � �  9  M .���  �   �  9  M ���     ���
  G �  H� M ����   �����       �@33�?    �      @@p      �¥       u  )  � I  � ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC A  {$CLEO .cs}
0000:
0006: 6@ = 0
0006: 7@ = 0  
:WaitKeyPress
wait 50 ms 
if and
    0256: player $PLAYER_CHAR defined
    80E0: not player $PLAYER_CHAR in_any_car 
jf @WaitKeyPress
if 0019: 7@ > 0 
then 000A: 7@ += -1 
end 
if 05EE: key_pressed 115 
jf @WaitKeyPress
if 0039: 7@ == 0 
then 0006: 6@ = 0 
end
if 0039: 6@ == 0 
then 0006: 8@ = 175 
end
if 0039: 6@ == 1 
then 0006: 8@ = 191 
end
if 0039: 6@ == 2 
then 0006: 8@ = 145 
end
if 0039: 6@ == 3 
then 0006: 8@ = 217 
end
0006: 7@ = 20
if 0039: 6@ == 3
then 0006: 6@ = 0
else 000A: 6@ += 1
end  
0247: load_model 8@ 
:LoadCar
if 8248: not model 8@ available 
jf @CreateCar
wait 0 ms  
jump @LoadCar 
:CreateCar
04C4: store_coords_to 0@ 1@ 2@ from_actor $PLAYER_ACTOR with_offset 0.0 4.0 1.4 
0395: clear_area 1 at 0@ 1@ 2@ radius 3.0
0170: 5@ = player $PLAYER_CHAR z_angle
000B: 5@ += -90.0 
00A5: 3@ = create_car 8@ at 0@ 1@ 2@
0175: set_car 3@ z_angle_to 5@
0229: set_car 3@ color_to 1 0 
01C3: remove_references_to_car 3@
0249: release_model 8@
wait 500 ms  
jump @WaitKeyPress�  __SBFTR 