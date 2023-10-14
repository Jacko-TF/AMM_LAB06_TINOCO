# AMM_LAB06_TINOCO
## List View Group 
>Para utilizar listas agrupadas en nuestro proyecto, primero creamos dos clases, la primera clase Student presenta atributos clásicos para un estudiantes,
>en este caso el nombre, el apellido y la edad, además de una concatenación en una sola línea. Luego tenemos una clase Section que hereda de la clase ObservableCollection cuya clase
>a coleccionar es la clase Student, aquí tenemos nuestros parámetros ShortName y LongName que seran los encabezados de nuestra lista.
>
>Luego necesitamos nuestra página de contenido que nombramos ListViewGroup, en el XAML tenemos un StackLayout como contenedor principal, luego dentro tenemos nuestro ListView denominado sectionView,
>tenemos que setear el valor true en isGroupingEnabled, vemos que nuestra clase section tiene los tributos LongName y ShortName, tenemos que setear el Binding LongName en GroupDisplayBinding, luego tenemos que setear
>el Binding ShortName al atributo GroupShortNameBinding de nuestro ListView.
>
>Luego necesitamos la etiqueta ListView.ItemTemplate donde definiremos los datos de nuestra lista, dentro creamos una etiqueta DataTemplate donde Tendremos la etiqueta TextCell donde como valor para el
>atributo Text es nuestro FullName de la clase Students.cs. En el archivo .cs de nuestro XAML ListVewGroup.xaml.cs necesitamos dos variables, primero un objeto ObservableCollection<Section> denominado sections, luego un
>objeto público del mismo tipo pero denominado Sections que retornara la data de sections, estos objetos tendran una colección de 4 secciones con sus respectivos alumnos. Luego generamos nuestra data para la lista de alumnos y secciones,
>finalmente seteamos la colleción sections en el atributo .ItemsSource de nuestro ListView denominado como sectionView.
>
>
>Los resultados los podemos ver en https://drive.google.com/drive/folders/1ttucKc_tCRIGBd-DAa_j99w1uJzxeNXI?usp=sharing
>
