// A '.tsx' file enables JSX support in the TypeScript compiler, 
// for more information see the following page on the TypeScript wiki:
// https://github.com/Microsoft/TypeScript/wiki/JSX
import * as React from 'react';

import './Demo.scss'; // import your scss file into component module

class Demo extends React.Component<any, any> {

	public render() {
		return (
			<div className="Demo">
				<h1>Tak to by mozna slo :-)</h1>
				<p>ASP.NET + React bohuzel si zatim nejsem jistej jestli to je lepsi cesta pro ekis</p>
			</div>
		)
	}
}

export default Demo;