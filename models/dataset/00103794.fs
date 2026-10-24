FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(0, 22.41652124410128) * mm, "end": v(0, -27.583478755898724) * mm});
            skPoint(sketch, "E1.1.internal.orphan", {"position": v(0.6800777351329893, 22.41652124410128) * mm});
            skPoint(sketch, "E1.23.internal.orphan", {"position": v(7.014393113827027, 0) * mm});
            skFitSpline(sketch, "E2", {"points": [v(0, 22.41652124410128) * mm, v(0.6800777351329893, 22.41652124410128) * mm, v(1.3769207983119223, 21.80445309984387) * mm, v(1.303528380485765, 20.85035579513308) * mm, v(0.6800777351329893, 20.410002744774694) * mm, v(1.120048185602865, 20.079737471473052) * mm, v(2.6245864391119955, 18.758680262529314) * mm, v(5.119917720712142, 15.896388348396943) * mm, v(6.074015025422933, 13.87810596191862) * mm, v(6.074015025422933, 12.043303527556768) * mm, v(4.459389116240274, 5.915062736463503) * mm, v(4.679565155886612, 5.73158278434703) * mm, v(5.230005983301738, 5.071053694342308) * mm, v(5.046526031185264, 4.594005041986913) * mm, v(4.202516017998363, 3.8967801072187522) * mm, v(4.546179084857727, 3.8485800470259934) * mm, v(5.36997733642178, 3.539655641997866) * mm, v(6.070206505720578, 2.8806171378531937) * mm, v(6.049611658676368, 2.2421732379863037) * mm, v(6.508356693522921, 1.9063940108346131) * mm, v(7.014393113827027, 1.535460869878784) * mm, v(7.014393113827027, 0) * mm, v(6.071964620182872, -1.1047109310620913) * mm, v(4.108200290152647, -2.021134285076196) * mm, v(4.218329337501931, -2.0915422538354935) * mm, v(4.160078018943759, -2.3391103577077232) * mm, v(4.087263627979618, -4.188590450228956) * mm, v(4.043080381083338, -4.861966254002749) * mm, v(4.141047558753322, -6.96825001356785) * mm, v(4.483930374317213, -9.46640102721433) * mm, v(6.247331318318423, -14.16880322086232) * mm, v(6.541230666430535, -14.217785717248391) * mm, v(7.520897587801845, -14.75660288815225) * mm, v(7.7168319431418135, -15.638303360152854) * mm, v(7.618864522705402, -16.275086494894566) * mm, v(8.500564509173154, -17.3037363981848) * mm, v(10.068032554432955, -18.185436870185406) * mm, v(11.635255891134625, -20.27439341880992) * mm, v(11.479742631376084, -23.384643076929407) * mm, v(11.635255891134625, -23.61791053890295) * mm, v(12.568330594357327, -24.47322909777924) * mm, v(12.646085767638038, -26.339378504224648) * mm, v(0, -27.583478755898724) * mm], "startDerivative": vector(40.164076154175426, 6.266692693132292) * mm, "endDerivative": vector(-236.56064107737083, 4.068658647677248) * mm});
            skPoint(sketch, "E3.orphan", {"position": v(0, -29.71717192196498) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0");
            revolve(context, id + "F1", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
    });