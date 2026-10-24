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
            skText(sketch, "E0", { "text": "MAYAN\n", "fontName": "OpenSans-Regular.ttf"});
            const initialGuessF0  = {"E0": [-0.15956, -0.02668, 1, 0, 0.06454]};
            skSetInitialGuess(sketch, initialGuessF0);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-53"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-54"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-55"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-56"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-57"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-58"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-59"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-60"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-61"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-62"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-63"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-64"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-65"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-66"),sQuery(id+"F0.wireOp",EDGE,"E0.sketch_text.stroke-67")])],"isStart":true});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1.bottom", {"start": v(-165.71715474128723, 63.33759427070618) * mm, "end": v(157.87437558174133, 63.33759427070618) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(-165.71715474128723, -56.283917278051376) * mm, "end": v(157.87437558174133, -56.283917278051376) * mm});
            skLineSegment(sketch, "E1.left", {"start": v(-165.71715474128723, 63.33759427070618) * mm, "end": v(-165.71715474128723, -56.283917278051376) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(157.87437558174133, 63.33759427070618) * mm, "end": v(157.87437558174133, -56.283917278051376) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=sQuery(id+"F2.wireOp",EDGE,"E1.left");
            var Q1;
            Q1=sQuery(id+"F2.wireOp",EDGE,"E1.bottom");
            var Q2;
            Q2=sQuery(id+"F2.wireOp",EDGE,"E1.top");
            var Q3;
            Q3=sQuery(id+"F2.wireOp",EDGE,"E1.right");
            extrude(context, id + "F3", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0, Q1, Q2, Q3]), "depth" : 76.2 * mm});
        }
        {
            var Q0;
            Q0=sQuery(id+"F2.wireOp",EDGE,"E1.left");
            var Q1;
            Q1=sQuery(id+"F2.wireOp",EDGE,"E1.bottom");
            var Q2;
            Q2=sQuery(id+"F2.wireOp",EDGE,"E1.top");
            var Q3;
            Q3=sQuery(id+"F2.wireOp",EDGE,"E1.right");
            extrude(context, id + "F4", {"bodyType" : ToolBodyType.SURFACE, "surfaceEntities" : qUnion([Q0, Q1, Q2, Q3]), "depth" : 25.4 * mm});
        }
    });